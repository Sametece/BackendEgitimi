using System;
using Microsoft.EntityFrameworkCore;

namespace FilmveKategoriSistemi.Entity;

public class Category
{
  public int Id { get; set; }

    public string CategoryName { get; set; } = string.Empty;

    // Her Categorynin 1 den fazla filmi olabilir
    public List<Movie> Movies { get; set; } = [];
}
