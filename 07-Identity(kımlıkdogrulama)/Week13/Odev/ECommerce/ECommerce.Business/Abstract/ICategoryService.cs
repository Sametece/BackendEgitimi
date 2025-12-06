using System;
using System.Linq.Expressions;
using ECommerce.Business.DTOs;
using ECommerce.Business.DTOs.ResponseDtos;
using ECommerce.Entity.Concrete;

namespace ECommerce.Business.Abstract;

public interface ICategoryService
{ 
    
    /// <summary>
    /// Kategori Id'sine göre Kategorileri Getirir.
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
   Task<ResponseDto<CategoryDto>>GetAsync(int id);


   Task<ResponseDto<IEnumerable<CategoryDto>>> GetAllAsync(
    Expression<Func<Category, bool>>? predicate, // filtrelemek için
    Func<IQueryable<Category>, IOrderedQueryable<Category>>? orderBy, // sıralama için
    bool? includeProducts = null, // ürünleri dahil etme seçeneği için
    int? productId = null, // belirli bir ürün Id'sine göre filtreleme için
    bool? isDeleted = null // silinmiş kayıtları dahil etme seçeneği için
   );

    Task<ResponseDto<int>>CountAsync();
   Task<ResponseDto<CategoryDto>> CreateAsync(CategoryCreateDto categoryCreateDto);

   Task<ResponseDto<NoContent>> UpdateAsync(int id, CategoryUpdateDto categoryUpdateDto);

   Task<ResponseDto<NoContent>> SoftDeleteAsync(int id);

   Task<ResponseDto<NoContent>> HardDeleteAsync(int id);
}
