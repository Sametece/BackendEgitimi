using System;
using AutoMapper;
using ECommerce.Business.Abstract;
using ECommerce.Business.DTOs;
using ECommerce.Data.Abstract;
using ECommerce.Data.Models;

namespace ECommerce.Business.Concrete;

public class ProductService : IProductService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public ProductService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<ProductDto> CreateProductAsync(ProductCreateDto productCreateDto)
    {
        var product = _mapper.Map<Product>(productCreateDto);

        await _unitOfWork.Products.AddAsync(product);
        await _unitOfWork.CompleteAsync();

        var productDto = _mapper.Map<ProductDto>(product);

        return productDto;
    }

    public async Task DeleteProductAsync(int id)
    {
        var deletedProduct = await _unitOfWork.Products.GetByIdAsync(id);
        if (deletedProduct != null)
        {
            _unitOfWork.Products.Remove(deletedProduct);
            await _unitOfWork.CompleteAsync();
        }
    }

    public async Task<IEnumerable<ProductDto>> GetAllProductsAsync()
    {
        var products = await _unitOfWork.Products.GetAllAsync();
        var productDtos = _mapper.Map<IEnumerable<ProductDto>>(products);
        return productDtos;
    }

    public async Task<IEnumerable<ProductDto>> GetLowStockProductsAsync(int threshold)
    {
        var result = await _unitOfWork.Products.GetLowStockProductsAsync(threshold);
        return null;
    }

    public async Task<ProductDto> GetProductByIdAsync(int id)
    {
        var result = await _unitOfWork.Products.GetByIdAsync(id);
        return null;
    }

    public async Task UpdateProductAsync(ProductUpdateDto productUpdateDto)
    {
        var updatedProduct = await _unitOfWork.Products.GetByIdAsync(productUpdateDto.Id);
        if (updatedProduct == null)
        {
            throw new ArgumentException("Güncellenecek ürün bulunamadı!");
        }
        updatedProduct.Name = productUpdateDto.Name;
        updatedProduct.Price = productUpdateDto.Price;
        updatedProduct.StockQuantity = productUpdateDto.StockQuantity;

        _unitOfWork.Products.Update(updatedProduct);
        await _unitOfWork.CompleteAsync();
    }


}
