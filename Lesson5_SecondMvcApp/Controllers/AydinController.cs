using Microsoft.AspNetCore.Mvc;

namespace Lesson5_SecondMvcApp.Controllers
{
    public class AydinController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
