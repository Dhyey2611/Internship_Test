using Microsoft.AspNetCore.Mvc;
using Internship_Test.Models;
using PracticeCodeFirst.Helpers;

namespace PracticeCodeFirst.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        [HttpPost("login")]
        public IActionResult Login([FromBody] UserLogin model)
        {
            if (model.Username == "admin" && model.Password == "1234")
            {
                var token = JwtHelper.GenerateToken(model.Username);
                return Ok(new { token });
            }

            return Unauthorized();
        }
    }
}