using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Soru1.Data;
using Soru1.Data.Entities;

namespace Soru1.Controllers
{
    [Route("api/[controller]")] // https://localhost:5050  /api/Movies
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly MovieContext _context;

        public MoviesController(MovieContext context)
        {
            _context = context;
        }

        [HttpGet]   //Tüm Filmleri Listele https://localhost:5050 /api/Movies
        public IActionResult GetAllMovies()
        {
            var movies = _context.Movies.ToList();
            return Ok(movies);
        }

        //id ye göre film getirme 
        [HttpGet("{id}")]   //https://localhost:5050 /api/movies/id   burdaki id sayı olucak 1 - 2 - 3 gibi
        public IActionResult GetMovieById(int id)
        {
            var movie = _context.Movies.Find(id); // Burdaki find metotu Where diyip idleri buluyorduk ya ona gerek kalmadan Bulma işlemi
            if (movie == null)
            {
                return NotFound(new { Message = $"{id} id'li bir ürün bulunmamaktadır." });
            }
            return Ok(movie);
        }

        [HttpPost] // film eklemek için kullanılır.
        public IActionResult CreateMovie([FromBody] Movie movie) //FromBody o içindeki propları doldurmaya yarar yani title , director gibi
        {
            if (movie == null)
            {
                return BadRequest(new { Message = "Ürün Boş olamaz" });
            }

            _context.Movies.Add(movie);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetMovieById), new { id = movie.Id }, movie);
            //ifadelerin başına gelir ve o ifade string olucak denir. Derleyici otomatik versin diye kullanıırız 
        }


        [HttpPut("{id}")] //Film Güncellemek için Kullanılır. İd ye göre 
        public IActionResult UpdateMovie(int id, [FromBody] Movie movie)
        {
            if (movie == null || movie.Id != id)
            {
                return BadRequest(new { Message = "Ürün Boş Veya İd Bilgileri Uyuşmuyor." });
            }

            var existingMovie = _context.Movies.Find(id);
            //“Veritabanında belirtilen ID’de bir film bul, varsa bilgilerini güncelle, değişiklikleri kaydet, yoksa 404 hatası döndür.”

            if (existingMovie == null)
            {
                return NotFound(new { Message = $"{id} id'li Film Bulunamadı" });
            }
            existingMovie.Title = movie.Title;
            existingMovie.Director = movie.Director;
            existingMovie.ReleaseYear = movie.ReleaseYear;

            _context.SaveChanges();
            return NoContent();

        }

        [HttpDelete("{id}")] // id ye göre film silme işlemi
        
        public IActionResult DeleteMovie(int id)
        {
            var movieToDelete = _context.Movies.Find(id);
            if (movieToDelete == null)
            {
                return NotFound(new { Message = "Film Bulunamadı" });
            }
            _context.Movies.Remove(movieToDelete);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
