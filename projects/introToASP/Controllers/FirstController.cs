using Microsoft.AspNetCore.Mvc;

namespace introToASP.Controllers
{
    public class FirstController : Controller 
    {
        //We run logic in a controller
        //This is where we control our routes and what happens at those routes
        //First, establish the type of route - GET/POST 
        //Second, we establish the name of the route
        //An empty "" takes me to the root page or front route
        [HttpGet]
        [Route("")]
        public ViewResult Index()
        {
            return View("Index"); //name of file in string without .cs
        }

        [HttpGet("second")]
        public string Second()
        {
            return "Hello from the second page.";
        }

        [HttpGet("third/{arbitrary}")]
        public string Third(string arbitrary)
        {
            return $"The thing you wrote is: {arbitrary}";
        }
    }
}