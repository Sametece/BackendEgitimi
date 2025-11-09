using Microsoft.EntityFrameworkCore;
using soru5.Data;

var builder = WebApplication.CreateBuilder(args); // inşaatçılar 


// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer(); // endpoint
builder.Services.AddSwaggerGen(); //swagger

//builder.Services.AddOpenApi();

builder.Services.AddDbContext<CustomerDbContext>(options =>
{
    options.UseSqlite("Data Source =Customer.db");
});

var app = builder.Build(); // inşaat bitti

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) // developer test yeri
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run(); // uygulamayı ayaklandır.
