using Microsoft.AspNetCore.Mvc;

namespace Kaizen.MainWeb.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("/api/home")]
        public IActionResult Get()
        {
            var value = new { id = 1 };
            return Ok(value);
        }
    }
}
