using System;
using System.ComponentModel.DataAnnotations;
using Project33_WebApiActionMethods.ValidationAttributes;


namespace Project33_WebApiActionMethods.Data.Entities;

public class Product
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Ürün adı zorunludur.")]
    [StringLength(100, MinimumLength = 3, ErrorMessage = "Ürün adı 3 ile 10 karakter arasında olmalıdır.")]
    [ForbiddenWord("test")]
    [UniqueProductName]
    public string? Name { get; set; }

    [MaxLength(500, ErrorMessage = "Açıklama en fazla 500 karakter olabilir.")]
    public string? Description { get; set; }

    [Required(ErrorMessage = "Fiyat zorunludur.")]
    [Range(0.01, double.MaxValue, ErrorMessage = "Fiyat 0.01'den büyük olmalıdır.")]
    public decimal? Price { get; set; }
}
