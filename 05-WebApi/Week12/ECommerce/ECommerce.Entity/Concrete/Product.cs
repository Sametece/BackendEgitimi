using System;

using ECommerce.Entity.Abstract;

namespace ECommerce.Entity.Concrete;

public class Product : BaseClass
{
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public int StockQuantity { get; set; }

    public string? Properties { get; set; }

    public  string? Imageurl { get; set; } //resimler için 

    public ICollection<ProductCategory>  ProductCategories { get; set; } = [];
}


