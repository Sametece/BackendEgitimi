using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using ECommerce.Business.Abstract;
using ECommerce.Business.Configs;
using ECommerce.Business.DTOs;
using ECommerce.Business.DTOs.ResponseDtos;
using ECommerce.Entity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;


namespace ECommerce.Business.Concrete;

public class AuthService : IAuthService
{
   
    //Dependency Injection ile UserManager, SignInManager ve RoleManager ı alıyoruz.
    private readonly UserManager<AppUser> _userManager;
    private readonly SignInManager<AppUser> _signInManager;
    private readonly RoleManager<AppRole> _roleManager;
     
     // appsettingsdeki jwt config ayarlarını almak için
    private readonly JwtConfig _jwtConfig;
    private readonly AppUrlConfig _appUrlConfig;

   //ctor
    public AuthService(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, 
    RoleManager<AppRole> roleManager, IOptions<JwtConfig> jwtConfig, IOptions<AppUrlConfig> appUrlConfig)
    { //sectionları IOptions ile alıyoruz. ve ctroda .value ile erişiyoruz.
        _userManager = userManager;
        _signInManager = signInManager;
        _roleManager = roleManager;
        _jwtConfig = jwtConfig.Value;
        _appUrlConfig = appUrlConfig.Value;
    }
     
     // Login metodu
    public async Task<ResponseDto<TokenDto>> LoginAsync(LoginDto loginDto)
    {
       try
       { // kullanıcı adı veya email ile giriş yapılabilmesi için önce kullanıcıyı bulmamız gerekiyor.
          var appUser = await _userManager.FindByNameAsync(loginDto.UserNameOrEmail) ?? await _userManager.FindByEmailAsync(loginDto.UserNameOrEmail);
          if(appUser is null)
          {
              return ResponseDto<TokenDto>.Fail("Kullanıcı adı /Email Hatalı", 400);
          }
          // Eğer Email mekanizması kullanılıyorsa, email onayını kontrol edebilirsiniz. Tam bu noktada.
          
          // Parolayı doğrula
          var isValidPassword = await _userManager.CheckPasswordAsync(appUser, loginDto.Password!);    
            if(!isValidPassword)
            {
                return ResponseDto<TokenDto>.Fail("Parola Hatalı", 400);
            }  

            // token üret ve gönder

            var tokenDto = await GenerateJwtToken(appUser);
            return ResponseDto<TokenDto>.Success(tokenDto, 200);
       }
       catch (Exception ex)
       {
           return ResponseDto<TokenDto>.Fail($"Hata : {ex.Message}", 500);
        throw;
       }
    }
    // Register metodu
    public async Task<ResponseDto<AppUserDto>> RegisterAsync(RegisterDto registerDto)
    {
        try
        {     // Kullanıcı adı ve emailin daha önce kayıtlı olup olmadığını kontrol et.
            var existingUser = await _userManager.FindByNameAsync(registerDto.UserName);
            if(existingUser is not null)
            {
                return ResponseDto<AppUserDto>.Fail("Kullanıcı adı zaten kayıtlı", 400);
            }
            var appUser = new AppUser // yeni kullanıcı oluşturuyoruz.
            {
                FirstName = registerDto.FirstName, 
                LastName = registerDto.LastName,
                UserName = registerDto.UserName,
                Email = registerDto.Email,
                EmailConfirmed = true // email onayı mekanizması eklenirse false yapılacak.
            };
             // Kullanıcıyı oluştur ve parolayı şifreleyerek kaydet. Db'ye.
            var resultCreateUser = await _userManager.CreateAsync(appUser, registerDto.Password);
            if(!resultCreateUser.Succeeded)
            {
                return ResponseDto<AppUserDto>.Fail($"Kullanıcı oluşturulamadı Bir hata meydana geldi. ", 500);
            }
            

           var  resultAddToRole = await _userManager.AddToRoleAsync(appUser, "User"); // yeni kayıt olan kullanıcıya User rolü veriyoruz.
            if(!resultAddToRole.Succeeded)
            {
                return ResponseDto<AppUserDto>.Fail($"Kullanıcıya rol ataması yapılamadı. Bir hata meydana geldi. ", 500);
            }
            // Email onay mekanizması eklenirse burada onay maili gönderme kodu göndeririz.
            // Kayıt başarılı ise kullanıcı bilgilerini döneriz.
            var appUserDto = new AppUserDto
            {
                Id = appUser.Id,
                FirstName =  appUser.FirstName,
                LastName = appUser.LastName,
                UserName = appUser.UserName,
                Email = appUser.Email
            };
            return ResponseDto<AppUserDto>.Success(appUserDto, 201);

        }
        catch (Exception ex)
        {
            return ResponseDto<AppUserDto>.Fail($"HATA: {ex.Message}", StatusCodes.Status500InternalServerError);
        }
    }




    private async Task<TokenDto> GenerateJwtToken(AppUser appUser)
    {
       try
       {
         // Token oluşturma işlemi burada yapılacak
        //1.Adım kullanıcının rollerini tespit et , rollerle birlikte kullanıcının diğer bilgilerini içerecek ve token içine eklecek calimleri oluştur.

        var roles = await _userManager.GetRolesAsync(appUser); // Admin , SuperAdmin , User rollerin alıyoruz. 
        var claims = new List<Claim>
        {
            new (ClaimTypes.NameIdentifier, appUser.Id) , 
              new (ClaimTypes.Name, appUser.UserName!),
              new (JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()) // her token için unique id guid oluşturuyoruz.
        }.Union(roles.Select(x => new Claim(ClaimTypes.Role, x))); // rolleride claim olarak ekliyoruz.
        

        //2.Adım : Token ın imzalanması için gerekli olan güvenlik anahtarını oluştur.Credentials oluştur.

        var key = new   SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtConfig.Secret!)); // appsettingsdeki secret ı byte dizisine çeviriyoruz.
        var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256); // hangi algoritmayı kullanacağımızı belirtiyoruz.
        
        //3.Adım : Token ın süresini belirle. 

        var expiry = DateTime.Now.AddDays(_jwtConfig.AccessTokenExpiration); // appsettingsten gün olarak alıyoruz.

        //4.Adım : token oluştur.

        var token = new JwtSecurityToken(
            issuer : _jwtConfig.Issuer, 
            audience : _jwtConfig.Audience, 
            claims : claims, 
            expires : expiry, 
            signingCredentials : credentials
        );

        var tokenDto = new TokenDto
        {
            AccesToken = new JwtSecurityTokenHandler().WriteToken(token), // token ı stringe çeviriyoruz.
            AccesTokenExpirationDate = expiry // token ın bitiş tarihini veriyoruz.
        };
        return tokenDto; 
       }
       catch (Exception ex)
       {
        
            throw new InvalidOperationException($"Token oluşturulurken hata oluştu : {ex.Message}");
       }

    }
}
