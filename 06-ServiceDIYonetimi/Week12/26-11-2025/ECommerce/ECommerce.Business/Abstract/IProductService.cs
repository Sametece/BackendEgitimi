using System;
using ECommerce.Business.DTOs;
using ECommerce.Business.DTOs.ResponseDtos;

namespace ECommerce.Business.Abstract;

public interface IProductService
{
    Task<ResponseDto<ProductDto>> GetAsync(int id, bool? includeCategories=true);
    Task<ResponseDto<IEnumerable<ProductDto>>> GetAllAsync(FilterDto? filterDto=null);
    Task<ResponseDto<IEnumerable<ProductDto>>> GetLowStockAsync(int threshold);

    Task<ResponseDto<int>> CountAsync();

    Task<ResponseDto<ProductDto>> CreateAsync(ProductCreateDto productCreateDto);
    Task<ResponseDto<NoContent>> UpdateAsync(int id, ProductUpdateDto productUpdateDto);
    Task<ResponseDto<NoContent>> SoftDeleteAsync(int id);
    Task<ResponseDto<NoContent>> HardDeleteAsync(int id);
    
}
