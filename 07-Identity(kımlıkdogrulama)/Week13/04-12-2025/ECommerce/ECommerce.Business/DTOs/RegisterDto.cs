using System;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.Business.DTOs;

public class RegisterDto
{
    [Required(ErrorMessage ="Ad bilgisi zorunludur!")]
    public string FirstName { get; set; } = string.Empty;


    [Required(ErrorMessage = "Soyad bilgisi zorunludur!")]
    public string LastName { get; set; } = string.Empty;


    [Required(ErrorMessage = "Email bilgisi zorunludur!")]
    public string Email { get; set; } = string.Empty; 

    [Required(ErrorMessage = "Kullanıcı Adı bilgisi zorunludur!")]
    public string UserName { get; set; } = string.Empty;

    [Required(ErrorMessage = "Parola zorunludur!")]
    public string Password { get; set; } = string.Empty; 


    [Required(ErrorMessage = "Parola tekrarı zorunludur!")]
    [Compare(nameof(Password),ErrorMessage = "parolalar uyuşmuyor.")] //password ile aynı olmalı
    public string ConfirmPassword { get; set; } = string.Empty;
}
