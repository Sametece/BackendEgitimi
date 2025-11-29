using System;
using ECommerce.Entity.Concrete;

namespace ECommerce.Business.DTOs;

public class ProductDto
{

    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime ModifiedAt { get; set; }
    public string? Name { get; set; } 
    public string? Properties { get; set; }
    public decimal Price { get; set; }
    public int StockQuantity { get; set; }
    public string? ImageUrl { get; set; }
    public string? IsDeleted { get; set; }

    public ICollection<CategoryDto>? Categories { get; set; }

}
