using System;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.Business.DTOs;

public class CreateCustomerDto
{
     [Required(ErrorMessage = "İsim Girmek Zorunludur !!!")]
   public string? FirstName { get; set; }

   public string? LastName { get; set; }
    
    [Required(ErrorMessage ="Mail adresi Boş geçilemez.")]
   public string? Email   { get; set; } 

   public string? City { get; set; }
}
