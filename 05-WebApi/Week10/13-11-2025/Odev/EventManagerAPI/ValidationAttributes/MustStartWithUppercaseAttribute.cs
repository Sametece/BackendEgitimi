using System;
using System.ComponentModel.DataAnnotations;

namespace EventManagerAPI.ValidationAttributes;

public class MustStartWithUppercaseAttribute : ValidationAttribute
{
 protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if (value is string str && !string.IsNullOrEmpty(str))
        {
            if (!char.IsUpper(str[0]))
            {
                return new ValidationResult("İsim büyük harf ile başlamalı.");
            }
        }
        return ValidationResult.Success;
    }
}
