using System;
using Microsoft.EntityFrameworkCore;
using soru4.Data.Concrete.interfaces;
using soru4.Dto;
using soru4.Entity;

namespace soru4.Data.Concrete.EFCore;

public class MovieRepository : IMovieRepository
{
    private readonly MovieContext _context;
    public MovieRepository(MovieContext context)
    {
        _context = context;
    }
    public void Add(Movie movie)
    {
        _context.Movies.Add(movie);
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var movie = GetById(id);
        if (movie != null)
        {
            _context.Movies.Remove(movie);
            _context.SaveChanges();
        }
    }

    public IEnumerable<Movie> GetAll()
    {
        var movie = _context.Movies
                            .AsNoTracking()
                            .ToList();
        return movie;
    }

    public List<MovieDetailDto> GetAllMovieDetails()
    {
     {   return _context.Movies
                 .AsNoTracking() // okuma: takip gerekli değil
                 .Include(m => m.Category) // Include yerine direkt projeksiyon da yeterli
                 .Select(m => new MovieDetailDto
                 {
                     Title = m.Title,
                     Director = m.Director,
                     CategoryName = m.Category.Name
                 })
                 .ToList();
    }
    }

    public Movie GetById(int id)
    {
        var movie = _context.Movies
                             .AsNoTracking()
                             .Where(m => m.Id == id)
                             .FirstOrDefault();
        return movie!;
    }

    public void Update(Movie movie)
    {
        _context.Movies.Update(movie);
        _context.SaveChanges();
    }
}

