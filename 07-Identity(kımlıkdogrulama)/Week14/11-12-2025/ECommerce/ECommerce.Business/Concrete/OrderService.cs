using System;
using System.Runtime.Intrinsics.Arm;
using AutoMapper;
using ECommerce.Business.Abstract;
using ECommerce.Business.DTOs;
using ECommerce.Business.DTOs.ResponseDtos;
using ECommerce.Data.Abstract;
using ECommerce.Entity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Business.Concrete;

public class OrderService : IOrderService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    private readonly IRepository<Product> _productRepository;
    private readonly IRepository<Order> _orderRepository;

    public OrderService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _productRepository = unitOfWork.GetRepository<Product>();
        _orderRepository = unitOfWork.GetRepository<Order>();
    }

    public Task<ResponseDto<NoContent>> CancelAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<ResponseDto<NoContent>> ChangeOrderStatusAsync(ChangeOrderStatusDto changeOrderStatusDto)
    {
        throw new NotImplementedException();
    }

    public async Task<ResponseDto<IEnumerable<OrderDto>>> GetAllAsync()
    {
        try
        {
            var orders = await _orderRepository.GetAllAsync(
                orderBy: x => x.OrderByDescending(o => o.CreatedAt),
                includes: query => query
                    .Include(x => x.AppUser)
                    .Include(x => x.OrderItems)
                    .ThenInclude(oi => oi.Product)
            );
            if (orders is null || !orders.Any())
            {
                return ResponseDto<IEnumerable<OrderDto>>.Fail("Herhangi bir sipariş bilgisi bulunamadı!", StatusCodes.Status404NotFound);
            }
            var orderDtos = _mapper.Map<IEnumerable<OrderDto>>(orders);
            return ResponseDto<IEnumerable<OrderDto>>.Success(orderDtos, StatusCodes.Status200OK);
        }
        catch (Exception ex)
        {
            return ResponseDto<IEnumerable<OrderDto>>.Fail(ex.Message, StatusCodes.Status500InternalServerError);
        }
    }

    public Task<ResponseDto<IEnumerable<OrderDto>>> GetAllAsync(string appUserId)
    {
        throw new NotImplementedException();
    }

    public Task<ResponseDto<IEnumerable<OrderDto>>> GetAllAsync(string appUserId, OrderStatus orderStatus)
    {
        throw new NotImplementedException();
    }

    public Task<ResponseDto<IEnumerable<OrderDto>>> GetAllAsync(string appUserId, DateTime startDate, DateTime endDate)
    {
        throw new NotImplementedException();
    }

    public Task<ResponseDto<IEnumerable<OrderDto>>> GetAllAsync(string appUserId, byte month)
    {
        throw new NotImplementedException();
    }

    public Task<ResponseDto<OrderDto>> GetAsync(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<ResponseDto<OrderDto>> OrderNowAsync(OrderNowDto orderNowDto)
    {
        try
        {
            // Sipariş edilen ürünler veri tabanında var mı yok mu kontrolü yapıyoruz
            foreach (var orderItem in orderNowDto.OrderItems)
            {
                var isExists = await _productRepository.ExistsAsync(p => p.Id == orderItem.ProductId);
                if (!isExists)
                {
                    return ResponseDto<OrderDto>.Fail($"{orderItem.ProductId} id'li ürün bulunamadığı için sipariş işlemi tamamlanamamıştır. Lütfen daha sonra yeniden deneyiniz!", StatusCodes.Status404NotFound);
                }
            }
            var order = _mapper.Map<Order>(orderNowDto);
            // Normalde tam bu aşamada ödeme operasyonu yapılmalı, ödeme başarılıysa order veri tabanına kaydedilmeli. Değilse order kaydedilmemeli.
            await _orderRepository.AddAsync(order);
            var result = await _unitOfWork.SaveAsync();
            if (result < 1)
            {
                return ResponseDto<OrderDto>.Fail("Sipariş veri tabanına kaydedilirken bir sorun oluştu!", StatusCodes.Status500InternalServerError);
            }
            // Normalde tam bu aşamada sepet boşaltılmalı.
            foreach (var orderItem in order.OrderItems)
            {
                orderItem.Product = await _productRepository.GetAsync(orderItem.ProductId);
            }
            var orderDto = _mapper.Map<OrderDto>(order);
            return ResponseDto<OrderDto>.Success(orderDto, StatusCodes.Status201Created);
        }
        catch (Exception ex)
        {
            return ResponseDto<OrderDto>.Fail(ex.Message, StatusCodes.Status500InternalServerError);
        }
    }
}
