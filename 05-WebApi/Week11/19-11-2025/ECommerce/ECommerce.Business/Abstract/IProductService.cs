using System;
using ECommerce.Business.DTOs;
using ECommerce.Data.Models;

namespace ECommerce.Business.Abstract;

public interface IProductService
{
    Task<ProductDto> GetProductByIdAsync(int id);
    Task<IEnumerable<ProductDto>> GetAllProductsAsync();
    Task<IEnumerable<ProductDto>> GetLowStockProductsAsync(int threshold);
    Task<ProductDto> CreateProductAsync(ProductCreateDto productCreateDto);
    Task UpdateProductAsync(ProductUpdateDto productUpdateDto);
    Task DeleteProductAsync(int id);
    
}
