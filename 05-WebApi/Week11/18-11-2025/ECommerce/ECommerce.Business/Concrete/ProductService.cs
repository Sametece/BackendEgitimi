using System;
using ECommerce.Business.Abstract;
using ECommerce.Data.Abstract;
using ECommerce.Data.Models;

namespace ECommerce.Business.Concrete;

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<Product> CreateProductAsync(Product product)
    {
        if (product.Price < 0)
        {
            throw new ArgumentException("Ürün fiyatı negatif olamaz!");
        }
        await _productRepository.AddAsync(product);
        return product;
    }

    public async Task DeleteProductAsync(int id)
    {
        var deletedProduct = await GetProductByIdAsync(id);
        if (deletedProduct == null)
        {
            throw new KeyNotFoundException("Silinmek istenen ürün bulunamadı!");
        }
        _productRepository.Remove(deletedProduct);
    }

    public async Task<IEnumerable<Product>> GetAllProductsAsync()
    {
        var result = await _productRepository.GetAllAsync();
        return result;
    }

    public async Task<IEnumerable<Product>> GetLowStockProductsAsync(int threshold)
    {
        var result = await _productRepository.GetLowStockProductsAsync(threshold);
        return result;
    }

    public async Task<Product> GetProductByIdAsync(int id)
    {
        var result = await _productRepository.GetByIdAsync(id);
        return result;
    }

    public async Task UpdateProductAsync(Product product)
    {
        var updatedProduct = await GetProductByIdAsync(product.Id);
        if (updatedProduct == null)
        {
            throw new ArgumentException("Güncellenecek ürün bulunamadı!");
        }
        updatedProduct.Name = product.Name;
        updatedProduct.Price = product.Price;
        updatedProduct.StockQuantity = product.StockQuantity;

        _productRepository.Update(updatedProduct);
    }
}
