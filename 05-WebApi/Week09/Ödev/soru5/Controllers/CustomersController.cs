using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using soru5.Data;
using soru5.Data.Entities;

namespace soru5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly CustomerDbContext _context;

        public CustomersController(CustomerDbContext context)
        {
            _context = context;
        }

        [HttpGet] //Tüm Verileri Getir
        public IActionResult GetAllCustomer()
        {
            var customer = _context.Customers.ToList();

            return Ok(customer);
        }

        [HttpGet("{id}")] //id'ye Göre Getir
        public IActionResult GetCustomerById(int id)
        {
            var customer = _context.Customers.Find(id);

            if (customer == null)
            {
                return NotFound(new { Message = $"{id} id'li Customer Bulunamadı..." });
            }
            return Ok(customer);

        }

        [HttpPost] // Yeni Veri Ekleme from body unutma

        public IActionResult CreateCustomer([FromBody] Customer customer)
        {
            if (customer == null)
            {
                return BadRequest(new { Message = $"Müşteri Bilgisi Boş olamaz.." });
            }
            _context.Customers.Add(customer);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetCustomerById), new { id = customer.Id }, customer);

        }


        [HttpPut("{id}")] // id'li Müşteriyi Güncelle

        public IActionResult UpdateCustomer(int id, [FromBody] Customer customer)
        {
            if (customer == null || customer.Id != id)
            {
                return BadRequest(new { Message = $"Customer boş yada id bilgileri uyuşmuyor..." });
            }
            var existingCustomer = _context.Customers.Find(id);

            if (existingCustomer == null)
            {
                return NotFound(new { message = $"{id} id'li Customer Bulunamadı." });
            }

            existingCustomer.FirstName = customer.FirstName;
            existingCustomer.LastName = customer.LastName;
            existingCustomer.Email = customer.Email;
            existingCustomer.PhoneNumber = customer.PhoneNumber;

            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")] // id'ye göre silme işlemi
        
        public IActionResult DeleteCustomer(int id)
        {
            var customers = _context.Customers.Find(id);
            if (customers == null)
            {
                return NotFound(new { Message = "Customer Bulunamadııı" });
            }
            _context.Customers.Remove(customers);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
