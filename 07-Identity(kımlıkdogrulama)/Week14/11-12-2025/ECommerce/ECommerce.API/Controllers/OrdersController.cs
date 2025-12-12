using ECommerce.Business.Abstract;
using ECommerce.Business.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.API.Controllers
{
    [Route("api/orders")]
    [ApiController]
    public class OrdersController : CustomControllerBase
    {
        private readonly IOrderService _orderService;

        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> OrderNow([FromBody] OrderNowDto orderNowDto)
        {
            orderNowDto.AppUserId = GetUserId();
            var response = await _orderService.OrderNowAsync(orderNowDto);
            return CreateResult(response);
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _orderService.GetAllAsync();
            return CreateResult(response);
        }
    }
}
