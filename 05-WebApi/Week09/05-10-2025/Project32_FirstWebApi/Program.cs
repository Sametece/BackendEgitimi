var builder = WebApplication.CreateBuilder(args); // inşaatçı



builder.Services.AddControllers();  // controller

builder.Services.AddOpenApi();

var app = builder.Build();  // inşaat bitti


if (app.Environment.IsDevelopment()) // developer görücek
{
    app.MapOpenApi();  //Hangi endpoint var, hangi veri türü gelir, 
                    // hangi yanıt döner — hepsi orada yazıyor.Bu sadece uygulama geliştirilirken test amaçlı olur
}

app.UseAuthorization(); // bekçi gibi düşün izin olup olmadığını soruyor

app.MapControllers(); // her controller kendi içinde route yapısını belirlicek

app.Run(); // uygulmayı ayaklandır 

