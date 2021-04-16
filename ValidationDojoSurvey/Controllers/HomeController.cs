using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ValidationDojoSurvey.Models;

namespace ValidationDojoSurvey.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
[HttpGet]
[Route("")]
        public IActionResult Index()
        {
            return View("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [HttpPost("newStudent")]
        public IActionResult Submit(Student Student) 
        {

            if (ModelState.IsValid)
            {
                TempData["FullName"]=Student.FullName;
                TempData["Location"] = Student.Location;
                TempData["Language"] = Student.Language;
                TempData["Comment"] = Student.Comment;
                return RedirectToAction("Result");
            }
            else
            {
            return View("Index");
            }
        }

// ////////////////////////////////////Result page rout\\\\\\\\\\\\\\\\\
        [HttpGet]
        [Route("result")]
        public IActionResult Result()
        {
            Student StudentInfo =new Student()
            {
                FullName=(string)TempData["FullName"],
                Location=(string)TempData["Location"],
                Language=(string)TempData["Language"],
                Comment=(string)TempData["Comment"]
            };
            return View("Result", StudentInfo);
        }
        // ///////////////////////////////Go Back rout form from result page\\\\\\\\\\\\\\\\\\\\\\\\
        [HttpPost]
        [Route("/submitToGoBack")]   //this rout is just for post method   

        public RedirectToActionResult submitToGoBack()

        {
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
