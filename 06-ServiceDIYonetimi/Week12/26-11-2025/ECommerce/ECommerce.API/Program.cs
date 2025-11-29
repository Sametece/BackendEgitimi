using ECommerce.Business.Abstract;
using ECommerce.Business.Concrete;
using ECommerce.Business.Mapping;
using ECommerce.Data;
using ECommerce.Data.Abstract;
using ECommerce.Data.Concrete;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddOpenApi();

var connectionString = builder.Configuration.GetConnectionString("SqliteConnection");

builder.Services.AddDbContext<ECommerceDbContext>(options => options.UseSqlite(connectionString));

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped(typeof(IRepository<>),typeof(Repository<>));
// Görüldüğü üzere, repository yaklaşımımızda her entity için özel repo sınıfları yazmadık. Generic bir yapı ile, istediğimiz zaman istediğimiz entity için generic repository'mizden bir repo elde ediyoruz. Ancak servisler için aynı yaklaşımı kullanmayacağız. İstenilirse, servisler için de benzer bir yaklaşım kullanılabilir.

builder.Services.AddScoped<IProductService, ProductService>();


builder.Services.AddAutoMapper(cfg=>{},typeof(MappingProfile));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
