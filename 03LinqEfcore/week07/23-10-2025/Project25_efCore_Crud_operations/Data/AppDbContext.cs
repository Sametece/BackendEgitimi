using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Project24_efCore_Basic.Models;

namespace Project24_efCore_Basic.Data;

public class AppDbContext:DbContext
{ 
    // veri tabanında posts adında tablo yarat kolonlarıda posttan gelsin 
   public DbSet<Post> Posts { get; set; }

   public DbSet<Author> Authors { get; set; }

   //override conf yazınca çıkıyor veri tabanı ile ilgili yeri başlatıyor
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    { //Eğer bu veri tabanı yoksa yaratır var kullanır.
      // optionsBuilder
      //             .UseSqlite("Data Source=blog.db")
      //             .LogTo(Console.WriteLine,LogLevel.Information)
      //             .EnableSensitiveDataLogging();
        optionsBuilder
                   .UseSqlite("Data Source=blog.db");
    }
}
