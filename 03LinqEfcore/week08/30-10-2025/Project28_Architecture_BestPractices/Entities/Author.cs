using System;

namespace Project28_Architecture_BestPractices.Entities;

public class Author
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public List<Post> Posts { get; set; } = [];

}
