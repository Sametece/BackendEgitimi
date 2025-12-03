using System;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.Business.DTOs;

public class RegisterDto
{
    [Required(ErrorMessage ="Ad bilgisi zorunludur!")]
    public string? FirstName { get; set; }


    [Required(ErrorMessage = "Soyad bilgisi zorunludur!")]
    public string? LastName { get; set; }


    [Required(ErrorMessage = "Email bilgisi zorunludur!")]
    public string? Email { get; set; }

    [Required(ErrorMessage = "Kullanıcı Adı bilgisi zorunludur!")]
    public string? UserName { get; set; }

    [Required(ErrorMessage = "Parola zorunludur!")]
    public string? Password { get; set; }


    [Required(ErrorMessage = "Parola tekrarı zorunludur!")]
    [Compare("M")]
    public string? ConfirmPassword { get; set; }
}
