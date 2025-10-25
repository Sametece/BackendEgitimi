using System;
using Microsoft.EntityFrameworkCore;
using Project26_efCore_relationship_data.Entites;

namespace Project26_efCore_relationship_data;

public class BlogDbContext:DbContext
{
   public DbSet<Author> Authors { get; set; }

   public DbSet<Post> Posts { get; set; }
   
   protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    { //Eğer bu veri tabanı yoksa yaratır var kullanır.
      // optionsBuilder
      //             .UseSqlite("Data Source=blog.db")
      //             .LogTo(Console.WriteLine,LogLevel.Information)
      //             .EnableSensitiveDataLogging();
        optionsBuilder
                   .UseSqlite("Data Source=blogapp.db");
    }
}
