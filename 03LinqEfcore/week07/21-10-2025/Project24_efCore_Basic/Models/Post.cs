using System;

namespace Project24_efCore_Basic.Models;

public class Post
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    
    public DateTime PublishedOn { get; set; }

}
