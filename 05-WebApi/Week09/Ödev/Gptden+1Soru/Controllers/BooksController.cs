using chat.Data;
using chat.Data.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace chat.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly BookDbContext _context;

        public BooksController(BookDbContext context)
        {
            _context = context;
        }

        //Atribute işlemler

        [HttpGet] // Tüm kitapları listele

        public IActionResult GetAllBook()
        {
            var book = _context.Books.ToList();
            return Ok(book);
        }

        [HttpGet("{id}")] // id'ye göre getirme işlemi

        public IActionResult GetBookById(int id)
        {
            var book = _context.Books.Find(id);

            if (book == null)
            {
                return NotFound(new { Message = $"{id} id'li Kitap Bulunamadı" });
            }

            return Ok(book);
        }

        [HttpPost] // Yeni Veri(Kitap)Ekleme[frombody]
        public IActionResult CreateBook([FromBody] Book book)
        {
            if (book == null)
            {
                return BadRequest(new { Message = "Kitap Giriniz Hata" });
            }

            _context.Books.Add(book);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetBookById), new { id = book.Id }, book);
        }

        [HttpPut("{id}")] //Veri Güncelleme İd ile FromBody unutma
        public IActionResult UpdateBook(int id, [FromBody] Book book)
        {
            if (book == null || book.Id != id)
            {
                return BadRequest(new { Message = $"Kitap Boş veya id bilgileri uyuşmuyor" });
            }

            var existingBook = _context.Books.Find(id);

            if (existingBook == null)
            {
                return NotFound(new { Message = $"{id} id'li kitap bulunamadı..." });
            }

            existingBook.Title = book.Title;
            existingBook.Author = book.Author;
            existingBook.Genre = book.Genre;
            existingBook.PublishedYear = book.PublishedYear;

            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")] //idye görme silme

        public IActionResult deleteToBook(int id)
        {
            var bookToDelete = _context.Books.Find(id);

            if (bookToDelete == null)
            {
                return NotFound(new { Message = $"Kitap Bulunamadı" });
            }

            _context.Books.Remove(bookToDelete);
            _context.SaveChanges();

            return NoContent();
        } 

    }
}
