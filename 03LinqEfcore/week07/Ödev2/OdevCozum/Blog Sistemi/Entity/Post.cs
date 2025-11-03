using System;

namespace Blog_Sistemi.Entity;

public class Post
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
        public DateTime PublishedDate { get; set; }

    // Her post yalnızca bir kategoriye aittir
        public Category? Category { get; set; }

    // Bir post'un birden fazla yorumu olabilir
    public List<Comment> Comments { get; set; } = [];

}
