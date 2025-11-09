using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using soru3.Data;
using soru3.Data.Entites;

namespace soru3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly TaskDbContext _context; // readonly
        public TasksController(TaskDbContext context) //ctor
        {
            _context = context;
        }

        [HttpGet] // Tüm Taskları Listele

        public IActionResult GetAllTasks()
        {
            var tasks = _context.ToDoTasks.ToList();

            return Ok(tasks);
        }

        [HttpGet("{id}")] //Belirtilen id ye göre Task Getir 

        public IActionResult GetTasksById(int id)
        {
            var tasks = _context.ToDoTasks.Find(id); //Belirtilen Id yi Bul
            if (tasks == null) // Eğer Id null ise 
            {
                return NotFound(new { Message = $"{id} id'li Task Bulunamadı" }); /// Hata Mesajı Döndür
            }
            return Ok(tasks); // Değilse Ok
        }

        [HttpPost] // Yeni Veri Ekle

        public IActionResult CreateTask([FromBody] ToDoTask toDoTask) // Yeni Task Oluştur Gövdesine Veri Ekle
        {
            if (toDoTask == null)
            {
                return BadRequest(new { Message = $"Task Boş olamaz..." });
            }
            _context.ToDoTasks.Add(toDoTask);
            _context.SaveChanges();
            return Ok(toDoTask);
        }

        [HttpPut("{id}")] // İdli veriyi Güncelle

        public IActionResult UpdateTask(int id, [FromBody] ToDoTask toDoTask)
        {
            if (toDoTask == null || toDoTask.Id != id)
            {
                return BadRequest(new { Message = " Task Boş veya id Bilgileri uyuşmuyor." });
            }

            var existingTask = _context.ToDoTasks.Find(id);
            if (existingTask == null)
            {
                return NotFound(new { Message = $"{id} id 'li ürün bulunamadı..." });
            }
            existingTask.Title = toDoTask.Title;
            existingTask.Description = toDoTask.Description;
            existingTask.IsCompleted = toDoTask.IsCompleted;
            existingTask.DueDate = toDoTask.DueDate;

            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")] // id ye göre sil
        
        public IActionResult DeleteTask(int id)
        {
            var taskDelete = _context.ToDoTasks.Find(id); // veritabanından id yi bul

            if (taskDelete == null) // girilen id  null ise 
            {
                return NotFound(new { Message = "Task Bulunamadı" }); // hata mesajı

            }

            _context.ToDoTasks.Remove(taskDelete); // değilse silme işlemi
            _context.SaveChanges();

            return NoContent();
        }
        

    }
}
