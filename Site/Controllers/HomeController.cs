using Microsoft.AspNetCore.Mvc;
using Site.ViewModels;
using System.Collections.Generic;

namespace Site.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<ProductViewModel>()
            {
                new(){ Name = "Mouse", Description = "A premium mouse", Price = 125.56 },
                new(){ Name = "Keyboard", Description = "A premium keyboard", Price = 225.56 },
                new(){ Name = "Monitor", Description = "A gamer monitor", Price = 2025.99 },
            };

            return View(products);
        }
    }
}
