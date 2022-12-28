using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyHotel.DiDemo;

namespace MyHotel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly IEmailGenerator emailGenerator;

        public TestController(IEmailGenerator emailGenerator)
        {
            this.emailGenerator = emailGenerator;
        }
        [HttpGet] 
        public IActionResult Get()
        {
            return Ok(emailGenerator.GenerateEmail());
        }
    }
}
