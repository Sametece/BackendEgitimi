using System;

namespace Efcoreodev.Entity;

public class Book
{
  public int Id { get; set; }

    public string Title { get; set; } = string.Empty;

    public int TotalPaper { get; set; }

    // Foreign key
    public int AuthorId { get; set; }

    // Navigation property
    public Author? Author { get; set; }
}
