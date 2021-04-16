using Microsoft.AspNetCore.Mvc;
namespace YourNamespace.Controllers     //be sure to use your own project's namespace!
{
    public class HomeController : Controller   //remember inheritance??
    {
        //for each route this controller is to handle:
        // Requests
        // localhost:5000/
        [HttpGet]       //type of request
        [Route("")]     //associated route string (exclude the leading /)

        // we need to chang string to the VIEWRESULT to redirect page to that page and rander it.
        public ViewResult Index()
        {
            // Views/Home/Index.cshtml We need to return thet index page to get all in our browser.
            // Views/Shared/Index.cshtml(if that file is not in the home folder it is going to look at the Shared folder)
            return View("Index");
        }
        // localhost:5000/projects
        [HttpGet]       //type of request
        [Route("projects")]
        public ViewResult Project()
        {
            // redirect to localhost:5000
            return  View("Projects");
        }
        [HttpGet]       //type of request
        [Route("contact")]
        public ViewResult Contact()
        {
            return View("Contact");
        }
        [HttpPost]
        [Route("/submitMessage")]
        public RedirectToActionResult SubmitMessage()
        {
            // redirectid to the indexpage
            return RedirectToAction("Index");
        }
    }
}