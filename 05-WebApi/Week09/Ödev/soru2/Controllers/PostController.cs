using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using soru2.Data;
using soru2.Data.Entites;

namespace soru2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly PostContext _context;

        public PostController(PostContext context)
        {
            _context = context;
        }

        [HttpGet] //Getirme işlemi get yapıyoruz
        public IActionResult GetAllPosts()
        {
            var posts = _context.Posts.ToList();
            return Ok(posts);
        }

        [HttpGet("{id}")] // id ye göre post getirme
        public IActionResult GetPostById(int id)
        {
            var post = _context.Posts.Find(id); //find Where işlemini yapıyor 
            if (post == null)
            {
                return NotFound(new { Message = $"{id} id'li bir ürün bulunmamaktadır." }); // hata mesajı
            }
            return Ok(post);
        }

        [HttpPost] //Veri Ekleme
        public IActionResult CreatePost([FromBody] Post post) //From Body bilgileri proplarını doldurma 
        {
            if (post == null)
            {
                return BadRequest(new { Message = "Ürün Boş olamaz !" });
            }

            _context.Posts.Add(post);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetPostById), new { id = post.Id }, post);
        }

        [HttpPut("{id}")]

        public IActionResult UpdatePost(int id, [FromBody] Post post)
        {
            if (post == null || post.Id != id)
            {
                return BadRequest(new { Message = $"ürün boş yada id bilgileri uyuşmuyor" });
            }
            var existingPost = _context.Posts.Find(id);
            if (existingPost == null)
            {
                return NotFound(new { Message = $"{id} id'li ürün bulunamadı" });
            }
            existingPost.Title = post.Title;
            existingPost.Content = post.Content;
            existingPost.Author = post.Author;

            _context.SaveChanges();
            return NoContent();

        }

        [HttpDelete("{id}")]

        public IActionResult DeletePost(int id)
        {
            var postToDelete = _context.Posts.Find(id);
            if (postToDelete == null)
            {
                return NotFound(new { Message = "Ürün Bulunamadı " });

            }
            _context.Posts.Remove(postToDelete);
            _context.SaveChanges();

            return NoContent();
        }

    }
}
