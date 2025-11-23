using ECommerce.Business.Abstract;
using ECommerce.Business.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var list = await _customerService.GetCustomerAllAsync();
            return Ok(list);
        }

        [HttpGet("{id:int}")] //int koy veya koyma önemli değil tipini belirttik
        public async Task<IActionResult> GetById(int id)
        {
            var customer = await _customerService.GetCustomerByIdAsyc(id);
            if (customer == null) return NotFound();
            return Ok(customer);
        }

       
    }
    }

