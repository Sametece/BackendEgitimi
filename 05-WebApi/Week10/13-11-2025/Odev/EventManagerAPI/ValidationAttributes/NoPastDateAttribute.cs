using System;
using System.ComponentModel.DataAnnotations;

namespace EventManagerAPI.ValidationAttributes;

public class NoPastDateAttribute : ValidationAttribute //Miras Alındı
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext) //Isvalid metodunu override ettik 
    {
        if (value is DateTime date)
        {
            if (date < DateTime.Now)
            {
                return new ValidationResult("Tarih geçmiş olamaz.");
            }
        }
        return ValidationResult.Success;
    }
}
  

