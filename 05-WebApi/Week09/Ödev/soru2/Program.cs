using Microsoft.EntityFrameworkCore;
using soru2.Data;

var builder = WebApplication.CreateBuilder(args); // inşaatçı

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers();
builder.Services.AddSwaggerGen();
//builder.Services.AddOpenApi();



//Veritabanı İşlemi Olucak şimdi 


builder.Services.AddDbContext<PostContext>(options =>
{
    options.UseSqlite("Data Source =Post.db");
});



var app = builder.Build();  // inşaat bitti


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) // Developerlar için test alanı
{
    // app.MapOpenApi();

    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run(); // uygulamayı ayaklandır
