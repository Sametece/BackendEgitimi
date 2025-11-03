using System;
using Microsoft.EntityFrameworkCore;
using soru4.Entity;

namespace soru4.Data;

public class MovieContext:DbContext
{
   public DbSet<Category> Categories { get; set; }

   public DbSet<Movie> Movies { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source = Movie.db");
    }
}
