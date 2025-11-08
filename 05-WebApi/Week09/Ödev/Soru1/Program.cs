using Microsoft.EntityFrameworkCore;
using Soru1.Data;

var builder = WebApplication.CreateBuilder(args); // inşaattıçı

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

//Şimdi Burada veritabanı classında küçük bir olay değiştirmiştik ya heh tam da orayı düzeltelim diyelim
builder.Services.AddDbContext<MovieContext>(options =>
{
    options.UseSqlite("Data Source = Movie.db");
});



var app = builder.Build();  // uygulamayı inşaatı bitti 


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) // developerların göreceği test alanı
{
    app.UseSwagger();
    app.UseSwaggerUI();
    //app.MapOpenApi();
}

app.UseAuthorization();

app.MapControllers();

app.Run(); // uygulamayı ayaklandır .
