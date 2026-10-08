using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class JohnryController : Controller
    {
        public IActionResult Profile()
        {
            return View();
        }
    }
}