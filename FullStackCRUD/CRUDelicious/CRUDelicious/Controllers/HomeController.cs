using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CRUDelicious.Models;

namespace CRUDelicious.Controllers
{
    public class HomeController : Controller
    {
        private CRUDEliciousContext db; //we paset same name as a our Context name 
        public HomeController(CRUDEliciousContext context)
        {
            db = context;
        }
        // //////////Adiing on the all lists in the index page  \\\\\\
        [HttpGet("")]
        public IActionResult Index()
        {
            List<Dish> allDishes = db.Dishes.ToList();
            return View("Index", allDishes);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
