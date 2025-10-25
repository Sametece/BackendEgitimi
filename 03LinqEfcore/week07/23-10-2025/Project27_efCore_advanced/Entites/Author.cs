using System;

namespace Project26_efCore_relationship_data.Entites;

public class Author
{
   public int Id { get; set; }

    public string FirstName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;

    public List<Post> Posts { get; set; } = [];
    
     
}
