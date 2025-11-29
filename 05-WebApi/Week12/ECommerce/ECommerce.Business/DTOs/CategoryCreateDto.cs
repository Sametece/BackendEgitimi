using System;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.Business.DTOs;

public class CategoryCreateDto
{
    [Required(ErrorMessage ="Kategori Adı Zorunludur.")]
    [MinLength(3,ErrorMessage ="Kategori adı en az 3 karekter olmalıdır.")]
 public string? Name { get; set; }

 public string? Description { get; set; }
}
