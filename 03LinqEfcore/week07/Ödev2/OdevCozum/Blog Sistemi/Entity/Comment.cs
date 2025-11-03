using System;

namespace Blog_Sistemi.Entity;

public class Comment
{
  public int Id { get; set; }
    public string AuthorName { get; set; } = string.Empty;
    public string Message { get; set; } = string.Empty;

        // Her yorum yalnızca bir post'a aittir
        public Post? Post { get; set; }


}
