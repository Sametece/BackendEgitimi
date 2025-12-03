using System;
using ECommerce.Business.DTOs.ResponseDtos;

namespace ECommerce.Business.Abstract;

public interface IAuthService
{
    Task<ResponseDto<????>> LoginAsync(string userName, string password);
}
