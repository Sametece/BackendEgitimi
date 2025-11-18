using EventManagerAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EventManagerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        [HttpPost]
        public IActionResult CreateEvent([FromBody]Event @event ) //normalde event yazardık direk bunu vscode kullandığı için izin vermedi otomatik başına @ koydu...
        {                   
            return Ok(@event);                                    //soruda böyle kalabilir dediği için ekleme metodunu girmedim ..
        }
    }
}
