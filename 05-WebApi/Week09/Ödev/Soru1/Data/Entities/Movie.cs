using System;

namespace Soru1.Data.Entities;

public class Movie
{
    public int Id { get; set; }

    public string Title { get; set; } = string.Empty;

    public string? Director { get; set; }

    public int ReleaseYear { get; set; }
}
