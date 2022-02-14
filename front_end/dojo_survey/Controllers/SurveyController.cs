using Microsoft.AspNetCore.Mvc;

namespace dojo_survey.Controllers
{
    public class SurveyController : Controller
    {
        // Logic runs in a controller
        // This is where we control our routes and what happens at those routes
        // First, establish the type of route - GET/POST

        [HttpGet("")]
        // Second, we establish the name of the route
        // An empty "" takes me to the root route
        public ViewResult Index()
        {
            return View("Index");
        }

        [HttpPost("dojoSurvey")]
        public IActionResult DojoSurvey(string name, string location, string language, string commentSection)
        {
            ViewBag.givenName = name;
            ViewBag.givenLocation = location;
            ViewBag.givenLanguage = language;
            ViewBag.filledCommentSection = commentSection;
            return View("surveyPost");
        }
    }
}