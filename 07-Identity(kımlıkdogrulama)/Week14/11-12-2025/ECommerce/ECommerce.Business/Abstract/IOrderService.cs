using System;
using ECommerce.Business.DTOs;
using ECommerce.Business.DTOs.ResponseDtos;
using ECommerce.Entity.Concrete;

namespace ECommerce.Business.Abstract;

public interface IOrderService
{
    //Siparil oluşturmnak için
    Task<ResponseDto<OrderDto>> OrderNowAsync(OrderNowDto orderNowDto);
    //Sipariş durumunu değiştirmek için 0-1-2-3
    Task<ResponseDto<NoContent>> ChangeOrderStatusAsync(ChangeOrderStatusDto changeOrderStatusDto);
    //Siparişi iptal etmek için
    Task<ResponseDto<NoContent>> CancelAsync(int id);
    //  Sipariş detaylarını getirmek için
    Task<ResponseDto<OrderDto>> GetAsync(int id);
    // Kullanıcıya ait tüm siparişleri getirmek için
    Task<ResponseDto<IEnumerable<OrderDto>>> GetAllAsync();
    // Kullanıcıya ait tüm siparişleri filtreleyerek getirmek için
    Task<ResponseDto<IEnumerable<OrderDto>>> GetAllAsync(string appUserId);
    // Sipariş durumuna göre filtreleyerek getirmek için
    Task<ResponseDto<IEnumerable<OrderDto>>> GetAllAsync(string appUserId, OrderStatus orderStatus);
    // Tarih aralığına göre filtreleyerek getirmek için
    Task<ResponseDto<IEnumerable<OrderDto>>> GetAllAsync(string appUserId, DateTime startDate, DateTime endDate);
    // Ay'a göre filtreleyerek getirmek için
    Task<ResponseDto<IEnumerable<OrderDto>>> GetAllAsync(string appUserId, byte month);
}
