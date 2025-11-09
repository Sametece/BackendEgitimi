using Microsoft.EntityFrameworkCore;
using soru3.Data;

var builder = WebApplication.CreateBuilder(args); // inşaatçılar gelsin

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer(); // servisleri çağır
builder.Services.AddSwaggerGen();  // servisleri çağır 
//builder.Services.AddOpenApi();


// Veritabanı işlemi 

builder.Services.AddDbContext<TaskDbContext>(options =>
{
    options.UseSqlite("Data Source = task.db");
});





var app = builder.Build(); // inşaat bitti

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) // Developer test
{
    //  app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run(); // uygulmayı ayaklandır
