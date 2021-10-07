using Auth.Context;
using Auth.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Auth.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get([FromServices] AuthContext context)
        {
            var users = context.Users.ToList();

            return Ok(users);
        }

        [HttpPost]
        public IActionResult Post([FromServices] AuthContext context, [FromBody] UserViewModel user)
        {
            var result = context.Users.Where(u => u.UserName == user.UserName && u.Password == user.Password);

            return Ok(result);
        }
    }
}
