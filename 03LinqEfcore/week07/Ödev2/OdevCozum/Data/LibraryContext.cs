using System;
using Microsoft.EntityFrameworkCore;
using OdevCozum.Entity;

namespace OdevCozum.Data;

public class LibraryContext : DbContext
{

    // Veri tabanında Authors ve Books adında 2 tablo yarat.
  public DbSet<Author> Authors { get; set; } 
  public DbSet<Book> Books { get; set; }

// Eğer Veritabanı yoksa yaratır varsa olanı kullanır.
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=Library.db"); // db ismi
    }

}
