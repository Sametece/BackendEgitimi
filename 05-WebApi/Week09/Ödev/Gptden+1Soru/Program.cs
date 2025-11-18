using chat.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args); //inşaatçılar


// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//builder.Services.AddOpenApi();

builder.Services.AddDbContext<BookDbContext>(options =>
{
    options.UseSqlite("Data Source = book.db");
});

var app = builder.Build(); // inşşaat bitti

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();// uygulamayı ayaklandır.
