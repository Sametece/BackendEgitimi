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

    // ✔ TÜM MÜŞTERİLER
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var response = await _customerService.GetCustomerAllAsync();
        return StatusCode(response.StatusCode, response);
    }

    // ✔ ID'YE GÖRE
    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetById(int id)
    {
        var response = await _customerService.GetCustomerByIdAsyc(id);
        return StatusCode(response.StatusCode, response);
    }

    // ✔ OLUŞTUR
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateCustomerDto dto)
    {
        var response = await _customerService.CreateCustomerAsync(dto);
        return StatusCode(response.StatusCode, response);
    }

    // ✔ GÜNCELLE
    [HttpPut("{id:int}")]
    public async Task<IActionResult> Update(int id, [FromBody] CreateCustomerDto dto)
    {
        var response = await _customerService.UpdateAsync(id, dto);
        return StatusCode(response.StatusCode, response);
    }

    // ✔ SİL
    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var response = await _customerService.DeleteAsync(id);
        return StatusCode(response.StatusCode, response);
    }
    }

       
    }
    

