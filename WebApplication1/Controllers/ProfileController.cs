using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

public class ProfileController : Controller
{
    public IActionResult Details()
    {
        // Dito iinitialize yung data?
        // Like make the projects as objects with some data for the model to get
        return View();
    }

    public IActionResult Menu()
    {
        return View();
    }

    public IActionResult Projects()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
