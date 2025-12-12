using System;
using ECommerce.Business.DTOs;
using ECommerce.Business.DTOs.ResponseDtos;

namespace ECommerce.Business.Abstract;

public interface IOrderService
{
    Task<ResponseDto<OrderDto>> OrderNowAsync(OrderNowDto orderNowDto);
    Task<ResponseDto<NoContent>> ChangeOrderStatusAsync(ChangeOrderStatusDto changeOrderStatusDto);
    Task<ResponseDto<NoContent>> CancelAsync(int id);
    Task<ResponseDto<OrderDto>> GetAsync(int id);
    Task<ResponseDto<OrderDto>> GetAllAsync();
    Task<ResponseDto<OrderDto>> GetAllAsync(string appUserId);
}
