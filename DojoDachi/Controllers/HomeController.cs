using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DojoDachi.Models;
using Microsoft.AspNetCore.Http;
using DojoDachi.Helpers;

namespace DojoDachi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        // ////////////////////////////////////Dochi\\\\\\\\\\\\\\\\\\\\\

        //////////////////////////////Routes\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        [HttpGet("")]
        public IActionResult Index()
        {

            DojodachiModel dog = HttpContext.Session.GetObjectFromJson<DojodachiModel>("dachi");
            if(dog==null)
            {
                dog = new DojodachiModel();
                HttpContext.Session.SetObjectAsJson("dachi", dog);
                return View("Index", dog);
            }else
            {
                return View("Index", dog);
            }
            
        }
        ///////////////////////////////////FEED\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        // ************************************************************************

        [HttpPost("Feed")]
        public IActionResult Feed()
        {
            string newButton = HttpContext.Session.GetString("Feed");
            HttpContext.Session.SetString("newButton","Feed");
            DojodachiModel dog=HttpContext.Session.GetObjectFromJson<DojodachiModel>("dachi");
            if(dog.meals>0)
            {
                Random rand = new Random();
                dog.meals --;
                var dontlike = rand.Next(0,4);
                if(dontlike !=0)
                {
                    dog.fullness=rand.Next(5,11);
                }else
                {
                    Console.WriteLine("Dog don't want to be feeded");
                }
            }
            else
            {
                Console.WriteLine("Out of meals");
            }
            HttpContext.Session.SetObjectAsJson("dochi", dog);
            return RedirectToAction("Index");
        }
        // //////////////////////////////////////////////////////
        ///////////////////////////////////Play\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        // ************************************************************************

        [HttpPost("Play")]
        public IActionResult Play()
        {
            string newButton = HttpContext.Session.GetString("Play");
            HttpContext.Session.SetString("newButton","Play");
            DojodachiModel dog = HttpContext.Session.GetObjectFromJson<DojodachiModel>("dachi");
            if (dog.energy > 5)
            {
                dog.energy-=5;
                Random rand = new Random();
                var dontlike = rand.Next(0, 4);
                if (dontlike == 0)
                {
                    Console.WriteLine("Did not enough playing now");
                }else if(dog.energy<5)
                    {
                        dog.happiness = rand.Next(5, 11);
                    }
                    HttpContext.Session.SetObjectAsJson("dochi", dog);
                    Console.WriteLine("Out of meals");
            }
            // Random rand =new Random();
            // //////////////////////////////////Comenting out to check other version\\\\\\\\\\\\\\
            // Dog.happiness+=rand.Next(5,10);
            // int? Playenergy = HttpContext.Session.GetInt32("newButton");
            // HttpContext.Session.SetInt32("newButton", Dog.happiness);
            // Console.WriteLine("Time To Play");
            // Console.WriteLine(Dog.happiness);
            return RedirectToAction("Index");
        }
        // //////////////////////////////////////////////////////
        ///////////////////////////////////Work\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        // ************************************************************************

        [HttpPost("Work")]
        public IActionResult Work()
        {
            DojodachiModel dog = HttpContext.Session.GetObjectFromJson<DojodachiModel>("dachi");
            string newButton = HttpContext.Session.GetString("Work");
            Random rand = new Random();
            dog.energy -= rand.Next(1, 10);
            int? PlayEnergy = HttpContext.Session.GetInt32("newButton");
            HttpContext.Session.SetInt32("newButton", dog.energy);
            Console.WriteLine("Time To Work");
            Console.WriteLine(dog.energy);
            dog.energy-=5;
            return RedirectToAction("Index");
        }
        // //////////////////////////////////////////////////////
        ///////////////////////////////////Sleep\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        // ************************************************************************

        [HttpPost("Sleep")]
        public IActionResult Sleep()
        {
            DojodachiModel dog = HttpContext.Session.GetObjectFromJson<DojodachiModel>("dachi");
            string newButton = HttpContext.Session.GetString("Sleep");
            Random rand = new Random();
            dog.meals-=rand.Next(0,5);
            int? PlayEnergy = HttpContext.Session.GetInt32("newButton");
            HttpContext.Session.SetInt32("newButton", dog.meals);
            Console.WriteLine("Time To Sleep");
            dog.meals-=5;
            dog.happiness-=5;
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
