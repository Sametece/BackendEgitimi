using System;

namespace Efcoreodev.Entity;

public class Author
{
    public int Id { get; set; }

    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;

    public string BirthYear { get; set; } = string.Empty;

    //  Bir yazarın birden fazla kitabı olabilir
    public List<Book> Books { get; set; } = [];
}
