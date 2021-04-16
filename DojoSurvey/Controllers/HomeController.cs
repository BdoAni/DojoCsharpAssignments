using Microsoft.AspNetCore.Mvc;
namespace YourNamespace.Controllers     //be sure to use your own project's namespace!
{
    public class HomeController : Controller   //remember inheritance??
    {
        //for each route this controller is to handle:
        // Requests
        // localhost:5000/
        [HttpGet]       
        [Route("")]     

        public ViewResult Index()
        {
            return View("Index");
        }
        // ////////////////////////////////TO THE RUSULT\\\\\\\\\\\\\\\\\\\\\\\\\
        // We are creating POST method to save data and redirect to the main page
        [HttpPost]
        [Route("/submit")]
        public ViewResult SubmitIndex(string FullName, string Location, string Languages, string Comment)
        {
            // to save and pass data  through post method 
            ViewBag.FullName = FullName;
            ViewBag.Location = Location;
            ViewBag.Languages = Languages;
            ViewBag.Comment= Comment;
            return View("Result");//here we want to be redirect to the Result page.
        }
        [HttpGet]
        [Route("result")]

        public ViewResult Result()

        {
            return View("Result");
        }
        // ////////////////////////////////TO THE Index\\\\\\\\\\\\\\\\\\\\\\\\\
        [HttpPost]      
        [Route("/submitToGoBack")]   //this rout is just for post method   

        public RedirectToActionResult submitToGoBack()

        {
            return RedirectToAction("Index");
        }
    }
}