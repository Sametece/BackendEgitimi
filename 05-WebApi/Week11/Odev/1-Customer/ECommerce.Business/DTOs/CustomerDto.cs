using System;

namespace ECommerce.Business.DTOs;

public class CustomerDto
{
     public int Id { get; set; }

   public string FirstName { get; set; }=string.Empty;

   public string LastName { get; set; }=string.Empty;

   public string Email   { get; set; } = string.Empty;

   public string City { get; set; }=string.Empty;
}
