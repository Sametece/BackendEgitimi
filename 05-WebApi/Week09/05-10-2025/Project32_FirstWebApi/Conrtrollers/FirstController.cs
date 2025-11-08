using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Project32_FirstWebApi.Conrtrollers
{
    [Route("api/[controller]")] // /api/first
    [ApiController]
    public class FirstController : ControllerBase
    {
        [HttpGet] //Attribute
        public string GetFirst()
        {
            return "Selam";
        }

        [HttpGet]
        [Route("second")]
        public string GetSecond()
        {
            return "İkinci Selam";
        }

        [HttpPost]
        public string PostFirst(string message)
        {
            return $"{message} mesajını gönderdiniz";
        }
    }
}
