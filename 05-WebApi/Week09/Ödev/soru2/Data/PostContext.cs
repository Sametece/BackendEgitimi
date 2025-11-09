using System;
using Microsoft.EntityFrameworkCore;
using soru2.Data.Entites;

namespace soru2.Data;

public class PostContext:DbContext
{
    public DbSet<Post> Posts { get; set; }

        public PostContext(DbContextOptions<PostContext> options) : base(options)
    {

    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Post>().HasData(
         new Post {Id =1, Title = "Yapay Zekanın Geleceği", Content = "Yapay zeka hayatımızın her alanına girmeye başladı.", Author = "Ahmet Yılmaz", PuslishedDate = new DateTime(2025, 1, 10) },
    new Post {Id =2, Title = "C# 13 Yenilikleri", Content = "Microsoft, C# dilinde performans ve minimal kod odaklı yeni özellikler tanıttı.", Author = "Elif Demir", PuslishedDate = new DateTime(2025, 2, 5) },
    new Post {Id =3, Title = "ASP.NET Core ile Web API", Content = "Web API geliştirme sürecinde dikkat edilmesi gereken en önemli noktaları derledik.", Author = "Murat Kaya", PuslishedDate = new DateTime(2025, 3, 20) },
    new Post {Id =4, Title = "Entity Framework Core Nedir?", Content = "EF Core, ORM yapısı sayesinde veritabanı işlemlerini kolaylaştırır.", Author = "Selin Aydın", PuslishedDate = new DateTime(2025, 4, 15) },
    new Post {Id =5, Title = "Minimal API Nedir?", Content = "ASP.NET Core 6 ile gelen Minimal API yapısını örneklerle anlattık.", Author = "Kemal Özkan", PuslishedDate = new DateTime(2025, 5, 3) },
    new Post {Id =6, Title = "Clean Architecture’a Giriş", Content = "Katmanlı mimari ile sürdürülebilir kod yapısı oluşturma rehberi.", Author = "Ayşe Gür", PuslishedDate = new DateTime(2025, 6, 22) },
    new Post {Id =7, Title = "LINQ Sorgularını Anlamak", Content = "LINQ, koleksiyonlar üzerinde sorgu yazmayı kolaylaştırır.", Author = "Hasan Tunç", PuslishedDate = new DateTime(2025, 7, 18) },
    new Post {Id =8, Title = "Dependency Injection Basitçe", Content = "Bağımlılıkları yönetmenin en kolay yolu: DI tasarım deseni.", Author = "Zeynep Koç", PuslishedDate = new DateTime(2025, 8, 9) },
    new Post {Id =9, Title = "Unit of Work Nedir?", Content = "Birden fazla işlem tek bir iş biriminde toplandığında hata riski azalır.", Author = "Oğuzhan Arslan", PuslishedDate = new DateTime(2025, 9, 1) },
    new Post {Id =10, Title = "Repository Pattern Kullanımı", Content = "Veritabanı erişimini soyutlayarak temiz kod yazmak artık çok kolay.", Author = "Ceren Uçar", PuslishedDate = new DateTime(2025, 10, 12) }

        );
    }
}
