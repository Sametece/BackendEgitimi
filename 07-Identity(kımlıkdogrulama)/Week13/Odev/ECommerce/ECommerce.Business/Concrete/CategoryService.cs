using System;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using AutoMapper;
using ECommerce.Business.Abstract;
using ECommerce.Business.DTOs;
using ECommerce.Business.DTOs.ResponseDtos;
using ECommerce.Data.Abstract;
using ECommerce.Data.Concrete;
using ECommerce.Entity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Business.Concrete;

public class CategoryService :ICategoryService
{
   private readonly IUnitOfWork _unitOfWork;
   private readonly IMapper _mapper;

   private readonly IRepository<Product> _productRepository;
   private readonly IRepository<Category> _categoryRepository;

    public CategoryService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _productRepository = _unitOfWork.GetRepository<Product>();
        _categoryRepository = _unitOfWork.GetRepository<Category>();
    }

    public async Task<ResponseDto<int>> CountAsync()
    {
        try
        {
            var count = await _categoryRepository.CountAsync();
            return ResponseDto<int>.Success(count,StatusCodes.Status200OK);
        }
        catch (Exception ex)
        {
             return ResponseDto<int>.Fail(ex.Message, StatusCodes.Status500InternalServerError);
        }
    }

    public Task<ResponseDto<CategoryDto>> CreateAsync(CategoryCreateDto categoryCreateDto)
    {
        throw new NotImplementedException();
    }

    public Task<ResponseDto<IEnumerable<CategoryDto>>> GetAllAsync(Expression<Func<Category, bool>>? predicate, Func<IQueryable<Category>, IOrderedQueryable<Category>>? orderBy, bool? includeProducts = null, int? productId = null, bool? isDeleted = null)
    {
        throw new NotImplementedException();
    }

    public async Task<ResponseDto<CategoryDto>> GetAsync(int id)
    {
        try
        {
            var category = await _categoryRepository.GetAsync(
                predicate: x => x.Id == id, //verdiğim id'yi getir
                asExpanded: true, //bağlantılı diğer tabloları
                includes: query => query.Include(x=> x.ProductCategories).ThenInclude(y => y.Product)

            );
            if(category == null)
            {
                return ResponseDto<CategoryDto>.Fail($"{id} id'li Kategori bulunamadı!!. ",StatusCodes.Status404NotFound);
            }
            var categoryDto = _mapper.Map<CategoryDto>(category);
            return ResponseDto<CategoryDto>.Success(categoryDto,200);
        }
        catch (Exception ex)
        {
            
            return ResponseDto<CategoryDto>.Fail(ex.Message, StatusCodes.Status500InternalServerError);
        }
    }

    public async Task<ResponseDto<NoContent>> HardDeleteAsync(int id)
    {
        try
        {
             var deletedCategory = await _categoryRepository.GetAsync(
                predicate: x => x.Id == id,
                showIsDeleted: true
             );
             if(deletedCategory == null)
            {
                return ResponseDto<NoContent>.Fail($"{id} id'li kategori bulunamadığı için silme işlemi gerçekleştirilememiştir.",404);
            }

            _categoryRepository.Remove(deletedCategory);

            var result = await _unitOfWork.SaveAsync();

            if (result < 1)
            {
                  return ResponseDto<NoContent>.Fail("Ürün silinmeye çalışılırken, veri tabanından kaynaklı bir sorun oluştu!", StatusCodes.Status500InternalServerError);
            }
            return ResponseDto<NoContent>.Success(StatusCodes.Status200OK);
        }
        catch (Exception ex)
        {
            return ResponseDto<NoContent>.Fail(ex.Message, StatusCodes.Status500InternalServerError);
        }
    }

    public async Task<ResponseDto<NoContent>> SoftDeleteAsync(int id)
    {
        try
        {
            var deletedCategory = await _categoryRepository.GetAsync(
                predicate: x => x.Id == id,
                showIsDeleted: true
            );
            if(deletedCategory == null)
            {
                return ResponseDto<NoContent>.Fail($"{id} id'li Kategori Bulunamadıği için silme işlemi gerçekleştirilemedi.",404);
            }

            deletedCategory.IsDeleted = !deletedCategory.IsDeleted;
            deletedCategory.ModifiedAt = DateTime.UtcNow;

            _categoryRepository.Update(deletedCategory);

            var result = await _unitOfWork.SaveAsync();

            if (result < 1)
            {
                return ResponseDto<NoContent>.Fail("Kategori silinmeye çalışılırken, veri tabanından kaynaklı bir sorun oluştu!", StatusCodes.Status500InternalServerError);
            }
            return ResponseDto<NoContent>.Success(StatusCodes.Status200OK);
        }
        catch (Exception ex)
        {
           return ResponseDto<NoContent>.Fail(ex.Message, StatusCodes.Status500InternalServerError);
        }
    }

   public async Task<ResponseDto<NoContent>> UpdateAsync(int id, CategoryUpdateDto categoryUpdateDto)
{
    try
    {
        // 1. Gönderilen id ile dto içindeki id eşleşiyor mu?
        if (id != categoryUpdateDto.Id)
        {
            return ResponseDto<NoContent>.Fail("Id bilgileri tutarsız!", StatusCodes.Status400BadRequest);
        }

        // 2. Güncellenecek kategori var mı?
        var updatedCategory = await _categoryRepository.GetAsync(
            predicate: x => x.Id == id
        );

        if (updatedCategory == null)
        {
            return ResponseDto<NoContent>.Fail( $"{id} id'li kategori bulunamadığı için, güncelleme işlemi yapılamadı.", StatusCodes.Status404NotFound
            );
        }

        // 3. Mapping (Dto → Entity)
        _mapper.Map(categoryUpdateDto, updatedCategory);
        updatedCategory.ModifiedAt = DateTime.UtcNow;

        // 4. Update
        _categoryRepository.Update(updatedCategory);

        // 5. Save
        var result = await _unitOfWork.SaveAsync();

        if (result < 1)
        {
            return ResponseDto<NoContent>.Fail(
                "Kategori güncellenirken, veri tabanından kaynaklı bir sorun oluştu!",
                StatusCodes.Status500InternalServerError
            );
        }

        return ResponseDto<NoContent>.Success(StatusCodes.Status200OK);
    }
    catch (Exception ex)
    {
        return ResponseDto<NoContent>.Fail(
            ex.Message,
            StatusCodes.Status500InternalServerError
        );
    }
}
}
