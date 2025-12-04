using System;
using ECommerce.Business.DTOs;
using ECommerce.Business.DTOs.ResponseDtos;
using ECommerce.Entity.Concrete;

namespace ECommerce.Business.Abstract;

public interface IAuthService
{
    Task<ResponseDto<TokenDto>> LoginAsync(LoginDto loginDto);
    Task<ResponseDto<AppUserDto>> RegisterAsync(RegisterDto registerDto);


}


