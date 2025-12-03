using ECommerce.Business.DTOs.ResponseDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.API.Controllers
{
    public class CustomControllerBase : ControllerBase
    {
        public static IActionResult CreateResult<T>(ResponseDto<T> responseDto)
        {
            return new ObjectResult(responseDto) {StatusCode = responseDto.StatusCode};
        }
    }
}
