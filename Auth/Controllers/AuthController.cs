using Auth.Context;
using Auth.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Auth.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        [HttpPost]
        [Route("login")]
        [AllowAnonymous]
        public IActionResult Post([FromServices] AuthContext context, [FromBody] UserViewModel user)
        {
            var result = context.Users.Where(u => u.UserName == user.UserName && u.Password == user.Password).FirstOrDefault();

            if (result == null)
                return Ok("UserName or Password incorrect");

            var token = TokenService.GenerateToken(result);
            var userViewModel = new UserViewModel() { UserName = result.UserName };

            return Ok(new
            {
                user = userViewModel,
                token = token
            });
        }
    }
}
