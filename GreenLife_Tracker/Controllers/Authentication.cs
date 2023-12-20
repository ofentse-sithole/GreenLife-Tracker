using Microsoft.AspNetCore.Mvc;

namespace GreenLife_Tracker.Controllers
{
    public class Authentication : Controller
    {
       
        //This is used for the user to login
        public IActionResult UserLogin()
        {
            return View();
        }

        //This is used for the user to register
        public IActionResult UserRegister()
        {
            return View();
        }
    }
}
