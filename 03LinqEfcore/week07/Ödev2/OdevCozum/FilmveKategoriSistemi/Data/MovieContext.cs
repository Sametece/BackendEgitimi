using System;
using FilmveKategoriSistemi.Entity;
using Microsoft.EntityFrameworkCore;

namespace FilmveKategoriSistemi.Data;

public class MovieContext : DbContext
{
     public DbSet<Category> Categories { get; set; } // claslarımı verdim

     public DbSet<Movie> Movies { get; set; }
    
     // Sen Movie adında db oluştur varsa kullan..
    protected override void OnConfiguring  (DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source= Movie.db");
    }
}
