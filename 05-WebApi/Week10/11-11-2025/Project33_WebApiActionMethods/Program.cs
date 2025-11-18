using Microsoft.EntityFrameworkCore;
using Project33_WebApiActionMethods.Data;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
// builder.Services.AddOpenApi();

// Buraya öyle bir kod yazacağız ki bizim için AppDbContext tipinde bir nesne yaratmalı ve bunu yaparken o contextin kullanacağı veri tabanı bağlantısını ilgili class'a gönderebilmeli
// new AppDbContext(options.UseSqlite("Data Source=database.db"))
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlite("Data Source=database.db");
});


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    // app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
