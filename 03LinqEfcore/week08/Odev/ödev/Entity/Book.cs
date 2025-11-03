using System;

namespace ödev.Entity;

public class Book
{
  public int Id { get; set; }

    public string Title { get; set; } = string.Empty;

    public int PageCount { get; set; }

    //navi

    //1 eserin yanlızca 1 tane yazarı olabilir ve de foreign key

    public int AuthorId { get; set; } // foregin key

    public Author? Author { get; set; }
}
