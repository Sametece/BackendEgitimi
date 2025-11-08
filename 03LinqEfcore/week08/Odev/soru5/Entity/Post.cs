using System;

namespace soru5.Entity;

public class Post
{
public int Id { get; set; }

    public string Title { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;

    public DateTime PublishedDate { get; set; } = DateTime.UtcNow;

    // Navi
    // 1 postun sadece 1 tane kategorisi olabilir

    public int CategoryId { get; set; }

    public Category? Category { get; set; }

    //1 post 1 den fazla Comment alabilir 

    public List<Comment> Comments { get; set; } = [];
    
}
