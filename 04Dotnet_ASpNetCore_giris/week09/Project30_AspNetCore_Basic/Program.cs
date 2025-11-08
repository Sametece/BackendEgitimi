// Bu kodlar Program classı içindeki metodundaki kodlar olarak düşün.

var builder = WebApplication.CreateBuilder(args); // Bir Web uygulması oluşuturucu -> İnşaatçılar

builder.Services.AddEndpointsApiExplorer(); // Yapılıcak olan isteklerin adreslerini keşfeder
builder.Services.AddSwaggerGen(); // Nasıl istek atılır nereye istek atılır  -> Dükkanımda bir rehber paneli kurmak istiyorum!


var app = builder.Build(); // Uygulamayı oluştur. -> Dükkanın inşaatı bitti

app.UseSwagger();
app.UseSwaggerUI(); // Test Menüsü

app.MapGet("/", () => "Merhaba Dünya"); // Ana Sayfanda Merhaba dünya yazsın.
//app.MapGet("/kategori", () => "Selam Dünyalılar"); // Local Hostumuzun yanına /kategori eklersek ekranda selam dünyalılar yazar.

app.Run(); // uygulmayı ayağa kaldır


//dotnet new webapi --no-https  projeyi çalıştırma komutu
//dotnet add package Swashbuckle.AspNetCore  gerekli paketi yükle 

//dotnet Watch çalıştırma komutu terminalde 

