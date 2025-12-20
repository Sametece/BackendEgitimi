using System;
using ECommerce.Business.DTOs;
using ECommerce.Business.DTOs.ResponseDtos;

namespace ECommerce.Business.Abstract;

public interface ICategoryService
{
    // id ile kategori getirme
    Task<ResponseDto<CategoryDto>> GetAsync(int id);
    // tüm kategorileri getirme
    Task<ResponseDto<IEnumerable<CategoryDto>>> GetAllAsync();
    // kategori sayısını getirme
    Task<ResponseDto<int>> CountAsync();
    // kategori oluşturma
    Task<ResponseDto<CategoryDto>> CreateAsync(CategoryCreateDto categoryCreateDto);
    // kategori güncelleme
    Task<ResponseDto<NoContent>> UpdateAsync(int id, CategoryUpdateDto categoryUpdateDto);
    // kategori silme (soft delete)
    Task<ResponseDto<NoContent>> SoftDeleteAsync(int id);
    Task<ResponseDto<NoContent>> HardDeleteAsync(int id);
}
