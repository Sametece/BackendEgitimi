using System;

namespace Project19_Constructor_Static;

public class Product
{

    public Product(string name)
    {
        Name = name;
        Properties = string.Empty;
    }
    public Product()
    {
        Name = string.Empty;
        Properties = string.Empty;
    }

    public Product(string name, string properties)
    {
        Name = name;
        Properties = properties;
    }
    public Product(string name, string properties, double price)
    {
        Name = name;
        Properties = properties;
        Price = price;
    }
    public int Id { get; set; }

    public string Name { get; set; }

    public string Properties { get; set; }

    public double Price { get; set; }
  
}
