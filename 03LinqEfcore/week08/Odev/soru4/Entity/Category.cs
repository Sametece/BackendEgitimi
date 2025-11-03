using System;

namespace soru4.Entity;

public class Category
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    //navi
    //1 Kategorinin birden fazla filmi olabilir
    public List<Movie> Movies { get; set; } = [];
}
