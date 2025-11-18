using System;
using System.ComponentModel.DataAnnotations;

namespace Project33_WebApiActionMethods.ValidationAttributes;

public class ForbiddenWordAttribute : ValidationAttribute
{
    private readonly string _forbiddenWord;
    public ForbiddenWordAttribute(string word)
    {
        _forbiddenWord = word;
        ErrorMessage = $"Ürün adı yasaklı olan '{_forbiddenWord}' kelimesini içeremez!";
    }

    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        var productName = value as string;
        if (!string.IsNullOrEmpty(productName) && productName.Contains(_forbiddenWord, StringComparison.OrdinalIgnoreCase))
        {
            return new ValidationResult(ErrorMessage);
        }
        return ValidationResult.Success;
    }

}
