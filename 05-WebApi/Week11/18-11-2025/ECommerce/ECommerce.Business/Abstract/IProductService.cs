using System;
using ECommerce.Data.Models;

namespace ECommerce.Business.Abstract;

public interface IProductService
{
    // Aslında burada daha önce öğrendiğiniz DTO yapılarını kullanmak daha mantıklı. 
    // Ancak şu an da Service/Repository kavramlarını öne çıkartmak için DTO kullanımını daha sonraya bırakıyoruz.
    Task<Product> GetProductByIdAsync(int id);
    Task<IEnumerable<Product>> GetAllProductsAsync();
    Task<IEnumerable<Product>> GetLowStockProductsAsync(int threshold);
    Task<Product> CreateProductAsync(Product product);
    Task UpdateProductAsync(Product product);
    Task DeleteProductAsync(int id);
    
}
