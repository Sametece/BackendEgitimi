using System;

namespace chat.Data.Entity;

public class Book
{
  public int Id { get; set; }
  public string? Title { get; set; }

  public string? Author { get; set; }

    public string Genre { get; set; } = string.Empty;

    public int PublishedYear { get; set; }

}
