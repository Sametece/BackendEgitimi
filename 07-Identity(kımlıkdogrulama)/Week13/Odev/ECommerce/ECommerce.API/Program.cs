using System.Text;
using ECommerce.Business.Abstract;
using ECommerce.Business.Concrete;
using ECommerce.Business.Configs;
using ECommerce.Business.Mapping;
using ECommerce.Data;
using ECommerce.Data.Abstract;
using ECommerce.Data.Concrete;
using ECommerce.Entity.Concrete;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddOpenApi();

var connectionString = builder.Configuration.GetConnectionString("SqliteConnection");

builder.Services.AddDbContext<ECommerceDbContext>(options => options.UseSqlite(connectionString));

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped(typeof(IRepository<>),typeof(Repository<>));
// Görüldüğü üzere, repository yaklaşımımızda her entity için özel repo sınıfları yazmadık. Generic bir yapı ile, istediğimiz zaman istediğimiz entity için generic repository'mizden bir repo elde ediyoruz. Ancak servisler için aynı yaklaşımı kullanmayacağız. İstenilirse, servisler için de benzer bir yaklaşım kullanılabilir.


builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();


builder.Services.AddAutoMapper(cfg=>{},typeof(MappingProfile));

 //JWT ayarları
builder.Services.Configure<JwtConfig>(builder.Configuration.GetSection("JwtConfig"));
builder.Services.Configure<AppUrlConfig>(builder.Configuration.GetSection("AppUrlConfig"));

//sectiondan JwtConfig nesnesini alalım.
var jwtConfig = builder.Configuration.GetSection("JwtConfig").Get<JwtConfig>();

//Identity ayarları, şifre kuralları vs.
builder.Services.AddIdentity<AppUser,AppRole>(options =>
{  
    //şifre kuralları vs. buraya eklenebilir.
     options.Password.RequireDigit = true;
    options.Password.RequireLowercase = true;
    options.Password.RequireNonAlphanumeric = true;
    options.Password.RequireUppercase = true;
    options.Password.RequiredLength = 8;

    // Kullanıcı adı ve email ayarları
    options.User.RequireUniqueEmail = true; 
    
}).AddEntityFrameworkStores<ECommerceDbContext>().AddDefaultTokenProviders();


builder.Services.AddAuthentication(options =>
{
     options.DefaultAuthenticateScheme=JwtBearerDefaults.AuthenticationScheme; //hangi authentication şeması kullanılacak
        options.DefaultChallengeScheme=JwtBearerDefaults.AuthenticationScheme; //hangi authentication şeması kullanılacak
}).AddJwtBearer(opt =>
{
     opt.TokenValidationParameters= new TokenValidationParameters
     {
        ValidateIssuer=true, //token üreticisi doğrulaması
        ValidIssuer = jwtConfig!.Issuer,  //sectiondan aldığımız issuer

        ValidateAudience=true, //token alıcısı doğrulaması
        ValidAudience = jwtConfig!.Audience, //sectiondan aldığımız audience

        ValidateLifetime=true, //token ömrü doğrulaması

        ValidateIssuerSigningKey=true, //imza doğrulaması
        IssuerSigningKey= new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtConfig!.Secret)), //imza anahtarı
     };
});



var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
