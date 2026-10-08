using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class JohnryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Profile()
        {
            return View();
        }

        public IActionResult Portfolio()
        {
            return View();
        }
    }
}