using System;
using System.ComponentModel.DataAnnotations;
using Project33_WebApiActionMethods.Data;
using Project33_WebApiActionMethods.Data.Entities;

namespace Project33_WebApiActionMethods.ValidationAttributes;

public class UniqueProductNameAttribute:ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        var dbContext = (AppDbContext)validationContext.GetService(typeof(AppDbContext))!;
        if (dbContext == null)
        {
            throw new InvalidOperationException("DbContext bulunamadı!");
        }
        var productName = value as string;
        var product = (Product)validationContext.ObjectInstance;
        var exists = dbContext
            .Products
            .Any(p => p.Name!.Equals(productName) && p.Id != product.Id);
        if (exists)
        {
            return new ValidationResult("Bu ürün adı kullanılmaktadır!");
        }
        return ValidationResult.Success;

    }
}
