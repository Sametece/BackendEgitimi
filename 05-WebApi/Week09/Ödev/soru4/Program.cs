using Microsoft.EntityFrameworkCore;
using soru4.Data;

var builder = WebApplication.CreateBuilder(args); // inşaatçı

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer(); // end point
builder.Services.AddSwaggerGen(); // swagget

//builder.Services.AddOpenApi();


//Veritabanı için 

builder.Services.AddDbContext<MovieDbContext>(options =>
{
    options.UseSqlite("Data Source = Movie.db");
});

var app = builder.Build(); // inşaatı bitti


if (app.Environment.IsDevelopment()) // developer test
{
    // app.MapOpenApi();
    app.UseSwagger();  // swagger
    app.UseSwaggerUI(); // swagger 
}

app.UseAuthorization();

app.MapControllers();

app.Run(); // uygulamayı ayaklandır.
