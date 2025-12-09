using System.Linq;
using ECommerce.Business.Abstract;
using ECommerce.Business.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoriesController : CustomControllerBase
{
    private readonly ICategoryService _categoryService;

    public CategoriesController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllCategories(
        [FromQuery] bool includeProducts = true,
        [FromQuery] int? productId = null,
        [FromQuery] bool? isDeleted = null)
    {
        var response = await _categoryService.GetAllAsync(
            predicate: x => true,
            orderBy: q => q.OrderByDescending(y => y.CreatedAt),
            includeProducts: includeProducts,
            productId: productId,
            isDeleted: isDeleted
        );

        return CreateResult(response);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetCategoryById(int id)
    {
        var response = await _categoryService.GetAsync(id);
        return CreateResult(response);
    }

    [HttpPost]
    public async Task<IActionResult> CreateCategory([FromBody] CategoryCreateDto categoryCreateDto)
    {
        var response = await _categoryService.CreateAsync(categoryCreateDto);
        return CreateResult(response);
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> UpdateCategory(int id, [FromBody] CategoryUpdateDto categoryUpdateDto)
    {
        var response = await _categoryService.UpdateAsync(id, categoryUpdateDto);
        return CreateResult(response);
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> SoftDeleteCategory(int id)
    {
        var response = await _categoryService.SoftDeleteAsync(id);
        return CreateResult(response);
    }

    [HttpDelete("hard-delete")]
    public async Task<IActionResult> HardDeleteCategory([FromQuery] int id)
    {
        var response = await _categoryService.HardDeleteAsync(id);
        return CreateResult(response);
    }

    [HttpGet("count")]
    public async Task<IActionResult> CountCategories()
    {
        var response = await _categoryService.CountAsync();
        return CreateResult(response);
    }
}

