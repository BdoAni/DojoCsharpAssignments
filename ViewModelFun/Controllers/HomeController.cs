using System;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;
using System.Collections.Generic;

namespace ViewModelFun.Controllers
{
    public class HomeController: Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            HomeParagraph someParagraph = new HomeParagraph()
            {
                paragraph = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Alias illo dicta, porro quidem sunt veniam nisi facere accusamus adipisci quas aperiam totam, quam fugit deserunt, optio ut animi quisquam delectus!  Lorem ipsum dolor sit amet consectetur, adipisicing elit. Recusandae, quam! Officiis hic labore ratione veniam, distinctio placeat atque maiores repellat neque repudiandae, doloribus, dolorum porro eveniet. Accusamus, et saepe. Beatae."
            };
            return View(someParagraph);
        }

        [HttpGet]
        [Route("numbers")]
        public IActionResult Numbers()
        {
            Random rand =new Random();
            int[] Numbers =new int[8];
                for(int i=0; i<Numbers.Length;i++ )
                {
                    Numbers[i]=rand.Next(0,99);
                    Console.WriteLine(rand.Next(0,99));//I did to check on the consol to print that numbers 
                };
            return View("Numbers", Numbers);
        }

        [HttpGet]
        [Route("users")]
        public IActionResult Users()
        {
            Users someUsers = new Users()
            {
        
                FirstName = "Sally",
                LastName = "Sanderson"

            };
            Users someUsers2 = new Users()
            {

                FirstName = "Sarah",
                LastName = "Sanderson"

            };
            Users someUsers3 = new Users()
            {

                FirstName = "Rene",
                LastName = "Ricky"

            };
            Users someUsers4 = new Users()
            {

                FirstName = "Barbarah",
                LastName = "Ricky"

            };
            List<Users>  userList = new List<Users>()
            {
                someUsers, someUsers2,someUsers3,someUsers4 
            };
            return View("Users", userList);
        }
        [HttpGet]
        [Route("user")]
        public IActionResult SingleUser()
        {
            SingleUser someUser = new SingleUser()
            {
                FullName = "Moose Phollips",
            };
            return View("User", someUser);
        }
    }
}