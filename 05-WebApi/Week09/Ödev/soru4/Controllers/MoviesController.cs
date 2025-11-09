using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using soru4.Data;
using soru4.Data.Entites;

namespace soru4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly MovieDbContext _context;

        public MoviesController(MovieDbContext context)
        {
            _context = context;
        }

        [HttpGet]// Tüm verileri getir
        public IActionResult GetAllMovie()
        {
            var movies = _context.Movies.ToList();
            return Ok(movies);
        }

        [HttpGet("{id}")] //id ye göre film getirme
        public IActionResult GetMovieById(int id)
        {
            var movies = _context.Movies.Find(id);
            if (movies == null)
            {
                return NotFound(new { Message = $"{id} id'li Film Bulunamadı" });
            }
            return Ok(movies);
        }

        [HttpPost] // Yeni film Ekleme
        public IActionResult CreateMovie([FromBody] Movie movie)
        {
            if (movie == null)
            {
                return BadRequest(new { Message = "Film Boş olamaz" });
            }

            _context.Movies.Add(movie);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetMovieById), new { id = movie.Id }, movie);
        }

        [HttpPut("{id}")] // id ye göre güncelleme
        public IActionResult UpdateMovie(int id, [FromBody] Movie movie)
        {
            if (movie == null || movie.Id != id)
            {
                return BadRequest(new { Message = " Film Boş veya id bilgileri uyuşmuyor !!!" });
            }
            var existingMovie = _context.Movies.Find(id);
            if (existingMovie == null)
            {
                return NotFound(new { Message = $"{id} id 'li film bulunamadı" });
            }
            existingMovie.Title = movie.Title;
            existingMovie.Director = movie.Director;
            existingMovie.ReleaseYear = movie.ReleaseYear;

            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")] // id ye göre film bulma 
        
        public IActionResult movieDelete(int id)
        {
            var movieDelete = _context.Movies.Find(id);
            if (movieDelete == null)
            {
                return NotFound(new { message = "id 'li Film Bulunamadı.." });
            }
            _context.Movies.Remove(movieDelete);
            _context.SaveChanges();

            return NoContent(); 
        }
    }

}
