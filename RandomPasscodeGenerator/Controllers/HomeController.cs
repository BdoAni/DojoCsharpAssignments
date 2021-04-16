using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RandomPasscodeGenerator.Models;
using Microsoft.AspNetCore.Http;
// using Newtonsoft.Json;

namespace RandomPasscodeGenerator.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
[HttpGet("")]
        public IActionResult Index()
        {
            Random rand = new Random();
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            string stringChars ="";
            Console.WriteLine("We are in the line 28");
            for (int i = 0; i<14; i++)
            {
        
            string newcount=chars[rand.Next(chars.Length)].ToString();
            stringChars += newcount;
            Console.WriteLine(newcount);
            }
            ViewBag.passcode = stringChars;
            if(HttpContext.Session.GetInt32("count")==null)//we are checking to see it is null
            {
                // it is first time page has been loaded no info yet.
                HttpContext.Session.SetInt32("count", 1);
            }
            ViewBag.count=HttpContext.Session.GetInt32("count");
            return View("Index");
        }
[HttpPost("/generator")]
public IActionResult Generator()
        {
            int? currentNumber = HttpContext.Session.GetInt32("count");
            currentNumber++;
            HttpContext.Session.SetInt32("count", (int)currentNumber);
            // ViewBag.count = HttpContext.Session.GetInt32("count");
            return RedirectToAction("Index");
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
