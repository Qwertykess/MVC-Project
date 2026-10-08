using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

public class ProfileController : Controller
{
    public IActionResult Details()
    {
        return View();
    }

    public IActionResult Menu()
    {
        return View();
    }

    public IActionResult Projects()
    {
        var proj = new List<ProjectsModel>();
        
        var proj1 = new ProjectsModel()
        {
            ProjID = 1,
            ProjName = "Simple C Projects",
            RepoLink = "https://github.com/Qwertykess/C-Projects.git",
            DateUpdated = new DateOnly(2024, 10, 7)
        };

        proj.Add(proj1);

        var proj2 = new ProjectsModel()
        {
            ProjID = 2,
            ProjName = "Antventure Game",
            RepoLink = "https://github.com/Qwertykess/Adventure-Game.git",
            DateUpdated = new DateOnly(2024, 10, 7)
        };

        proj.Add(proj2);

        var proj3 = new ProjectsModel()
        {
            ProjID = 3,
            ProjName = "Matrix Inverter (Group Project)",
            RepoLink = "https://github.com/Qwertykess/matrix-inverter.git",
            DateUpdated = new DateOnly(2026, 1, 18)
        };

        proj.Add(proj3);

        var proj4 = new ProjectsModel()
        {
            ProjID = 4,
            ProjName = "Portfolio using MVC Architecture",
            RepoLink = "https://github.com/Qwertykess/MVC-Project.git",
            DateUpdated = new DateOnly(2026, 10, 8)
        };

        proj.Add(proj4);

        return View(proj); // Return the value to View(value)
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
