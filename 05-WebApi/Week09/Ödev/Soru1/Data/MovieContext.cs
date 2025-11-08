using System;
using Microsoft.EntityFrameworkCore;
using Soru1.Data.Entities;

namespace Soru1.Data;

public class MovieContext : DbContext // Miras alındı
{
    public DbSet<Movie> Movies { get; set; }  // classı tanımladık dbset şeklinde

    public MovieContext(DbContextOptions<MovieContext> options) : base(options)// ctor verdik
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Movie>().HasData(
            new Movie { Id = 1, Title = "Hızlı ve Öfkeli", Director = "H. Moritz", ReleaseYear = 2005 },
            new Movie { Id = 2, Title = "Yüzüklerin Efendisi: Kralın Dönüşü", Director = "Peter Jackson", ReleaseYear = 2003 },
            new Movie { Id = 3, Title = "Başlangıç", Director = "Christopher Nolan", ReleaseYear = 2010 },
            new Movie { Id = 4, Title = "Matrix", Director = "Lana Wachowski, Lilly Wachowski", ReleaseYear = 1999 },
            new Movie { Id = 5, Title = "Gladyatör", Director = "Ridley Scott", ReleaseYear = 2000 },
            new Movie { Id = 6, Title = "Avatar", Director = "James Cameron", ReleaseYear = 2009 },
            new Movie { Id = 7, Title = "Joker", Director = "Todd Phillips", ReleaseYear = 2019 },
            new Movie { Id = 8, Title = "Interstellar", Director = "Christopher Nolan", ReleaseYear = 2014 },
            new Movie { Id = 9, Title = "Karayip Korsanları: Siyah İnci'nin Laneti", Director = "Gore Verbinski", ReleaseYear = 2003 },
            new Movie { Id = 10, Title = "Titanic", Director = "James Cameron", ReleaseYear = 1997 }
        );

    }

}

