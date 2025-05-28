using Microsoft.AspNetCore.Mvc;

namespace Email_Service_Provider.Controllers
{
    [ApiController]
    [Route("/")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("✅ Email Service is up and running");
        }
    }
}
