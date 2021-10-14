using Microsoft.AspNetCore.Mvc;
using Site.ViewModels;

namespace Site.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(LoginViewModel login)
        {
            return View();
        }
    }
}
