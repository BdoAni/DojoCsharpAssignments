using Microsoft.AspNetCore.Mvc;
namespace YourNamespace.Controllers     //be sure to use your own project's namespace!
{
    public class HelloController : Controller   //remember inheritance??
    {
        //for each route this controller is to handle:
        [HttpGet]       //type of request
        [Route("")]     //associated route string (exclude the leading /)
        public string Index()
        {
            return "This is my Index!";
        }
         [HttpGet]       //type of request
        [Route("projects")] 
        public string Project()
        {
            return "These are my projects!";
        }
          [HttpGet]       //type of request
        [Route("contact")] 
            public string Contact()
        {
            return "This is my Contact!";
        }
    }
}
