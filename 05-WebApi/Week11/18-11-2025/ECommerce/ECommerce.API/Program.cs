using ECommerce.Business.Abstract;
using ECommerce.Business.Concrete;
using ECommerce.Data;
using ECommerce.Data.Abstract;
using ECommerce.Data.Concrete;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

// "Data Source=ECommerce.db" git bunu appsettings.json dosyasından oku
var connectionString = builder.Configuration.GetConnectionString("SqliteConnection");

builder.Services.AddDbContext<ECommerceDbContext>(options => options.UseSqlite(connectionString));

/*
    Servisleri DI Container'a kaydederken her bir servis için bir yaşam süresi belirlenir. Bunlar üç çeşittir:
    1) AddSingleton(): Uygulama çalıştığı sürece tek bir örnek(instance) oluşturulur. Her zaman, herkes bu örneği kullanır.
    2) AddTransient(): Her istendiğinde(yani kullanılmak üzere alındığında) yeni bir örnek oluşturulur. Çok istisnai durumlarda, sorun çözmek için kullanılır.
    3) AddScoped(): Her bir HTTP isteği için yeni bir örnek oluşturulur. Aynı istek içinde farklı yerlerde yeniden istense bile aynı örnek kullanılmaya devam eder. İstek sona erdiğinde örnek yok edilir. 
*/

builder.Services.AddScoped<IProductRepository, ProductRepository>();

// DI Container'a ProductService tipinde bir nesne yaratıp koy, uygulama içinde senden ne zaman IProductService tipindeki nesneyi vermeni istersem bana bu yarattığın ProductService örneğini ver.
builder.Services.AddScoped<IProductService, ProductService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
