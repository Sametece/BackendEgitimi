using System;

namespace soru4.Entity;

public class Movie
{
  public int Id { get; set; }

    public string Title { get; set; } = string.Empty;

    public string Director { get; set; } = string.Empty;

    public int ReleaseYear { get; set; }

    //navi
    //1 filmin sadece 1 tane kategorisi olabilir

    public int CategoryId { get; set; }

    public Category? Category { get; set; }
}
