using _06_10_2025.Data;
using _06_10_2025.Data.Entites;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _06_10_2025.Controllers
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

        [HttpGet("{id}")] // http://localhost:5090/api/products/4
        //[Route("{id}")] // http://localhost:5090/api/products/4
        public IActionResult GetProductById(int id)
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

    }
}


/*

Şu anda GetProductById metodumuz şu iki sonuçtan birini döndürebiliyor:
1) Bulamazsa
    {
        "message": "44 id'li bir ürün bulunmamaktadır!"
    }
2) Bulursa
    {
        "id": 6,
        "name": "Nike Air Max 270",
        "description": "Hava taban teknolojili spor ayakkabı, konfor ve stil bir arada",
        "price": 4999
    }
Oysa biz BENZER YAPIDA YANITLAR DÖNDÜRMEYİ GENELDE TERCİH EDERİZ!
Örneğin;
Bulsa da bulmasa da;
1) Bulamazsa
    {
        "message": "Kayıt bulunamadı",
        "result": null,
        "statusCode": 404
    }
2) Bulursa
    {
        "message": "",
        "result": {
            "id": 6,
            "name": "Nike Air Max 270",
            "description": "Hava taban teknolojili spor ayakkabı, konfor ve stil bir arada",
            "price": 4999
        },
        "statusCode": 200
    }

*/