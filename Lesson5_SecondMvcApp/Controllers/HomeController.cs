using Microsoft.AspNetCore.Mvc;

namespace Lesson5_SecondMvcApp.Controllers;


public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Contact()
    {
        return View();
    }

    public IActionResult About()
    {
        return View();
    }

    public IActionResult Gallary()
    {
        return View();
    }

}
