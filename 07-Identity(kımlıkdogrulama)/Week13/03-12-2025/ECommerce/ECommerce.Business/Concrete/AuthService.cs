using System;
using ECommerce.Business.Abstract;
using ECommerce.Business.Configs;
using ECommerce.Business.DTOs;
using ECommerce.Business.DTOs.ResponseDtos;
using ECommerce.Entity.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;

namespace ECommerce.Business.Concrete;

public class AuthService : IAuthService
{

    private readonly UserManager<AppUser> _userManager;
    private readonly SignInManager<AppUser> _signInManager;
    private readonly RoleManager<AppRole> _roleManager;

    private readonly JwtConfig _jwtConfig;
    private readonly AppUrlConfig _appUrlConfig;

    public AuthService(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, 
    RoleManager<AppRole> roleManager, IOptions<JwtConfig> jwtConfig, IOptions<AppUrlConfig> appUrlConfig)
    { //sectionları IOptions ile alıyoruz. ve ctroda .value ile erişiyoruz.
        _userManager = userManager;
        _signInManager = signInManager;
        _roleManager = roleManager;
        _jwtConfig = jwtConfig.Value;
        _appUrlConfig = appUrlConfig.Value;
    }

    public async Task<ResponseDto<TokenDto>> LoginAsync(LoginDto loginDto)
    {
       try
       { // kullanıcı adı veya email ile giriş yapılabilmesi için önce kullanıcıyı bulmamız gerekiyor.
          var user = await _userManager.FindByNameAsync(loginDto.UserName!) ?? await _userManager.FindByEmailAsync(loginDto.UserName!);
       }
       catch (Exception ex)
       {
           return ResponseDto<TokenDto>.Fail($"Hata : {ex.Message}", 500);
        throw;
       }
    }

    public Task<ResponseDto<AppUserDto>> RegisterAsync(RegisterDto registerDto)
    {
        throw new NotImplementedException();
    }
}
