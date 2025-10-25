using System;

//DTO : Data Transfer Object 
namespace Project26_efCore_relationship_data.DTos;

public class PostDto
{
   public int PostId { get; set; }
    public string PostTitle { get; set; } = string.Empty;

    public string AuthorName { get; set; } = string.Empty;
}
