using System;

namespace ECommerce.Entity.Concrete;

public class ProductCategory //eşleşme için oluşan tablo / class
{
  public int ProductId { get; set; }

  public Product? Product { get; set; }
  public int CategoryId { get; set; }

  public Category? Category { get; set; }

}

