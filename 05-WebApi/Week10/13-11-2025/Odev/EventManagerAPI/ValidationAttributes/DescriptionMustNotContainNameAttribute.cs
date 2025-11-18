using System;
using System.ComponentModel.DataAnnotations;
using EventManagerAPI.Model;

namespace EventManagerAPI.ValidationAttributes;

public class DescriptionMustNotContainNameAttribute : ValidationAttribute
{
 protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        var eventInstance = (Event)validationContext.ObjectInstance;
        var description = value as string;

        if (!string.IsNullOrEmpty(description) && !string.IsNullOrEmpty(eventInstance.Name))
        {
            if (description.Contains(eventInstance.Name))
            {
                return new ValidationResult("Açıklama, etkinlik adını içeremez.");
            }
        }

        return ValidationResult.Success;
    }
}
