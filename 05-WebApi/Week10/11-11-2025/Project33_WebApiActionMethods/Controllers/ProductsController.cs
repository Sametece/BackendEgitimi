using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project33_WebApiActionMethods.Data;
using Project33_WebApiActionMethods.Data.Entities;

namespace Project33_WebApiActionMethods.Controllers
{
    [Route("api/products")] // http://localhost:5090/api/products
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProductsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAllProducts()
        {
            var products = _context.Products.ToList();
            return Ok(products);
        }

        [HttpGet("{id:int}")] // http://localhost:5090/api/products/4
        //[Route("{id}")] // http://localhost:5090/api/products/4
        public IActionResult GetProductById([FromRoute] int id)
        {
            // var product = _context.Products.Where(p => p.Id == id);
            var product = _context.Products.Find(id);
            if (product == null)
            {
                return NotFound(new { Message = $"{id} id'li bir ürün bulunmamaktadır!" });
            }
            return Ok(product);
        }

        [HttpPost] // http://localhost:5090/api/products
        public IActionResult CreateProduct([FromBody] Product product)//Model Binding
        {
            if (product == null)
            {
                return BadRequest(new { Message = "Ürün boş olamaz!" });
            }
            _context.Products.Add(product);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetProductById), new { id = product.Id }, product);
            // return Created();
        }

        [HttpPut("{id}")] // http://localhost:5090/api/products/4
        public IActionResult UpdateProduct(int id, [FromBody] Product product)
        {
            if (product == null || product.Id != id)
            {
                return BadRequest(new { Message = "Ürün boş ya da id bilgileri uyuşmuyor!" });
            }
            var existingProduct = _context.Products.Find(id);
            if (existingProduct == null)
            {
                return NotFound(new { Message = $"{id} id'li ürün bulunamadı!" });
            }
            existingProduct.Name = product.Name;
            existingProduct.Price = product.Price;
            existingProduct.Description = product.Description;

            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var productToDelete = _context.Products.Find(id);
            if (productToDelete == null)
            {
                return NotFound(new { Message = "Ürün bulunamadı" });
            }
            _context.Products.Remove(productToDelete);
            _context.SaveChanges();

            return NoContent();
        }

        [HttpGet("search")]
        public IActionResult SearchProducts([FromQuery] string? keyword, [FromQuery] decimal? maxPrice)
        {
            IQueryable<Product> query = _context.Products.AsQueryable();
            if (!string.IsNullOrEmpty(keyword))
            {
                query = query.Where(p => p.Name!.ToLower().Contains(keyword.ToLower()) || p.Description!.ToLower().Contains(keyword.ToLower()));
                // şu an büyük küçük harf duyarlı çalışıyor. bunu es geçmesi için ne yapılabilir?
            }
            if (maxPrice.HasValue)
            {
                query = query.Where(p => p.Price <= maxPrice.Value);
            }
            var products = query.ToList();
            return Ok(products);
        }
    }
}

/*
    [FromRoute]:Veriyi URL'in path(yol) kısmından alır. api/products/6
    [FromQuery]:Veriyi requestin(isteğin) querystring(sorgu) kısmından alır. api/products/search?name=apple
    [FromBody]: Veriyi requestin(isteğin) body'sinden(gövdesinden) alır. POST/PUT içindeki JSON veri

    NOT:Bir isteğin içinde sadece bir tane [FromBody] olabilir.
*/