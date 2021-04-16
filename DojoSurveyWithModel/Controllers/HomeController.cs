using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DojoSurveyWithModel.Models;

namespace DojoSurveyWithModel.Controllers
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
[HttpGet]
[Route("result")]
        public IActionResult Result()
        {
            return View("Result");
        }
[HttpPost]
[Route("result")]
        public IActionResult Result(Student yourStudent)
        {
            // to save and pass data  through post method 
            return View("Result", yourStudent);//here we want to be redirect to the Result page.
        }
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
