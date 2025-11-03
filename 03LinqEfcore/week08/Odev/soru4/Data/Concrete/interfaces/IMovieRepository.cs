using System;
using soru4.Dto;
using soru4.Entity;

namespace soru4.Data.Concrete.interfaces;

public interface IMovieRepository
{
     Movie GetById(int id);
    IEnumerable<Movie> GetAll();

    void Add(Movie movie);
    void Update(Movie movie);

    void Delete(int id);


    //Dto
    List<MovieDetailDto> GetAllMovieDetails();
}
