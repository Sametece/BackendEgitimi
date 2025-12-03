using System;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.Business.DTOs;

public class LoginDto
{
    [Required(ErrorMessage = "Kullanıcı adı ya da Email bilgisi zorunludur!")]
    public string? UserNameOrEmail { get; set; }

    [Required(ErrorMessage = "Parola zorunludur!")]
    public string? Password { get; set; }

}
