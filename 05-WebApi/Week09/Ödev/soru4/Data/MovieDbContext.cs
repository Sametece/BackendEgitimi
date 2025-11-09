using System;
using Microsoft.EntityFrameworkCore;
using soru4.Data.Entites;

namespace soru4.Data;

public class MovieDbContext:DbContext
{
   public DbSet<Movie> Movies { get; set; }

    public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options) // ctor
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Movie>().HasData(

new Movie { Id = 1, Title = "Inception", Director = "Christopher Nolan", ReleaseYear = 2010 },
new Movie { Id = 2, Title = "The Matrix", Director = "Lana Wachowski, Lilly Wachowski", ReleaseYear = 1999 },
new Movie { Id = 3, Title = "Interstellar", Director = "Christopher Nolan", ReleaseYear = 2014 },
new Movie { Id = 4, Title = "The Shawshank Redemption", Director = "Frank Darabont", ReleaseYear = 1994 },
new Movie { Id = 5, Title = "Fight Club", Director = "David Fincher", ReleaseYear = 1999 },
new Movie { Id = 6, Title = "Forrest Gump", Director = "Robert Zemeckis", ReleaseYear = 1994 },
new Movie { Id = 7, Title = "The Dark Knight", Director = "Christopher Nolan", ReleaseYear = 2008 },
new Movie { Id = 8, Title = "Pulp Fiction", Director = "Quentin Tarantino", ReleaseYear = 1994 },
new Movie { Id = 9, Title = "Gladiator", Director = "Ridley Scott", ReleaseYear = 2000 },
new Movie { Id = 10, Title = "Avatar", Director = "James Cameron", ReleaseYear = 2009 }
        );
    }
}
