using System;
using ECommerce.Business.DTOs;
using ECommerce.Business.DTOs.ResponseDtos;

namespace ECommerce.Business.Abstract;

public interface IOrderService
{
    // Sipariş oluşturma
    Task<ResponseDto<OrderDto>> OrderNowAsync(OrderNowDto orderNowDto);
    // Sipariş durumu değiştirme işlemi
    Task<ResponseDto<NoContent>> ChangeOrderStatusAsync(ChangeOrderStatusDto changeOrderStatusDto);
    // Siparişi iptal etme
    Task<ResponseDto<NoContent>> CancelAsync(int id);
    // Sipariş detaylarını getirme
    Task<ResponseDto<OrderDto>> GetAsync(int id);
    // Tüm siparişleri veya belirli bir kullanıcıya ait siparişleri getirme
    Task<ResponseDto<OrderDto>> GetAllAsync();
    // Belirli bir kullanıcıya ait siparişleri getirme
    Task<ResponseDto<OrderDto>> GetAllAsync(string appUserId);
}
