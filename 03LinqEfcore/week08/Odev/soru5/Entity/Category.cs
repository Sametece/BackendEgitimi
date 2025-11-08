using System;

namespace soru5.Entity;

public class Category
{
public int Id { get; set; }
    public string Name { get; set; } = string.Empty;


    //Navi
    //1 kategori 1 den fazla post içerebilir.

    public List<Post> Posts { get; set; } = [];
    
}
