using System;

namespace ödev.Entity;

public class Author
{
    public int Id { get; set; }
    public string FullName { get; set; } = string.Empty;

    public int BirthYear { get; set; }

    //navi prop 1 yazarın 1 den fazla eseri olabilir

    public List<Book> Books { get; set; } = [];
}
