using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LoginRegister.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace LoginRegister.Controllers
{
    public class HomeController : Controller
    {
        private LoginRegisterContext db; //we paset same name as a our Context name 
        public HomeController(LoginRegisterContext context)
        {
            db = context;
        }
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }
        // /////////////************************Register****************************\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        [HttpPost("/register")]
        public IActionResult Register(User newUser)
        {
            if(ModelState.IsValid)//checking on validation
            {
                bool existingUser = db.Users.Any(u =>u.Email == newUser.Email);//checking if email is exites in the DB
                if(existingUser)//if user is existing 
                {
                    ModelState.AddModelError("Email", "is existing. ");// we are adding message about it
                }
            }
            if(ModelState.IsValid==false)
            {
                //So Error messages will be displayed
                return View("Index");
            }
            PasswordHasher<User> hasher=new PasswordHasher<User>();//creating hash
            newUser.Password =hasher.HashPassword(newUser,newUser.Password);
            db.Users.Add(newUser);
            db.SaveChanges();
            HttpContext.Session.SetInt32("UserId", newUser.UserId);
            return RedirectToAction("Success");
        }
        // ///****************************************Login*********************************\\\\\\\\\\\\\\\\\\\\\\
[HttpPost("/Login")]
        public IActionResult Login(LoginUser loginUser)
    {
        string genericErrMsg="Invalid Email or Password";
            if (ModelState.IsValid ==false)
            {
                return View("Index");
            }
            User dbUsers=db.Users.FirstOrDefault(user =>user.Email==loginUser.LoginEmail);
            
                if(db.Users==null)
                {
                    ModelState.AddModelError("LoginEmil", genericErrMsg);
                    return View("Index");
                }
            PasswordHasher<LoginUser> hasher = new PasswordHasher<LoginUser>();
            PasswordVerificationResult pwCompareResult=hasher.VerifyHashedPassword(loginUser, dbUsers.Password, loginUser.LoginPassword);
        if(pwCompareResult ==0)
                {
                    ModelState.AddModelError("LoginEmail", genericErrMsg);
                    return View("Index");
                }
                HttpContext.Session.SetInt32("UserId", dbUsers.UserId);
                return RedirectToAction("Success");
            }

        // ////**********************Success**************************\\\\\\\\\\\\\\\
        [HttpGet("success")]
        public IActionResult Success()
        {
            return View("Success");
        }
        // ////////////////////////////////************Logout***********\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        [HttpPost("/logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
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

    // internal class PasswordHasher<T>
    // {
    //     internal string HashPassword(User newUser, string password)
    //     {
    //         throw new NotImplementedException();
    //     }
    // }
}
