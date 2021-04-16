using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FormSubmition.Models;

namespace FormSubmition.Controllers
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
        public IActionResult Success()
        {
            return View("Success");
        }
[HttpPost("result")]
        public IActionResult Submit(User user)//this function Submit is supost to be same as a in the <form asp-action="Submit" asp-controller="Home" method="POST">
        {
            if(ModelState.IsValid)
            {
            return RedirectToAction("Success");
            }else
            {
            return View("Index");
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
