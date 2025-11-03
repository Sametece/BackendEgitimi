using System;

namespace Blog_Sistemi.Entity;

public class Category
{
   public int Id { get; set; }

    public string CategoryName { get; set; } = string.Empty;

    // Bir kategorinin birden fazla postu olabilir
    public List<Post> Posts { get; set; } = [];
}
