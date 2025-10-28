using System;

namespace FilmveKategoriSistemi.Entity;

public class Movie
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;

    public string Director { get; set; } = string.Empty;

    public int Year { get; set; }

    // Foregin key 
    //1 Filmin sadece 1 tane Categorysi olabilir 

    public int CategoryId { get; set; }

    public Category? Category { get; set; }
}
