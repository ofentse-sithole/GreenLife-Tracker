using GreenLife_Tracker.Models;
using Microsoft.AspNetCore.Builder.Extensions;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace GreenLife_Tracker.Controllers
{
    public class Dashboard : Controller
    {

        
    

        public IActionResult Index()
        {
            return View();
        }

        //This is gonna be used for DietChanges
        public IActionResult DietChanges()
        {
            return View();
        }
        
        //Tips that will help the user perform for exercising
        public IActionResult Tips()
        {
            return View();
        }

        //This is gonna be used for storing and see the pictures and videos that are stored
        public IActionResult Media()
        {
            return View();
        }

        

        //This is gonna be used for Goals and Challenges
        public IActionResult GoalsAndChallenges()
        {
            return View();
        }
    }
}
