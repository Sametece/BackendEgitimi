using System;

namespace ECommerce.Business.DTOs;

public class TokenDto
{
  public string? AccesToken { get; set; }
  public DateTime AccesTokenExpirationDate { get; set; } 
}
