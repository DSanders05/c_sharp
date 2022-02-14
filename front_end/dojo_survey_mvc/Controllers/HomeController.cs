using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using dojo_survey_mvc.Models;

namespace dojo_survey_mvc.Controllers
{
    public class HomeController : Controller
    {
        public static List<Survey> allSurveys = new List<Survey>();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost("dojoSurvey")]
        public IActionResult dojoSurvey(Survey newSurvey)
        {
            if(ModelState.IsValid){
            allSurveys.Add(newSurvey);
            return RedirectToAction("showSurvey");
            }
            else{
                return View("Index");
            }
        }

        [HttpGet("allSurveys")]
        public IActionResult showSurvey()
        {
            return View("AllSurveys", allSurveys);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
