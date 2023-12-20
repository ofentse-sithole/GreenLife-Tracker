using Microsoft.AspNetCore.Mvc;

namespace GreenLife_Tracker.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
