using System;

namespace soru5.Entity;

public class Comment
{
    public int Id { get; set; }
    public string AuthorName { get; set; } = string.Empty;

    public string Message { get; set; } = string.Empty;


    // 1 Comment sadece 1 posta ait olabilir 

    public int PostId { get; set; }

    public Post? Post { get; set; }
}
