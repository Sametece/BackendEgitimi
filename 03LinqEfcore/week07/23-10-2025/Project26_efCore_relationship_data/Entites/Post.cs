using System;

namespace Project26_efCore_relationship_data.Entites;

public class Post
{
   public int Id { get; set; }

    public string Title { get; set; } = string.Empty;

    public string Content { get; set; } = string.Empty;

    public DateTime PublishedOn { get; set; } = DateTime.UtcNow;

    public int AuthorId { get; set; }
}
