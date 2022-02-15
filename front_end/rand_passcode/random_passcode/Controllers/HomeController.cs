using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using random_passcode.Models;
using Microsoft.AspNetCore.Http;


namespace random_passcode.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            if(HttpContext.Session.GetString("code")== null){
                HttpContext.Session.SetString("code","ABJADFIEFFSDJS");
                HttpContext.Session.SetInt32("counter",1);
            }
            ViewBag.generatedPass=HttpContext.Session.GetString("code");
            ViewBag.counter=HttpContext.Session.GetInt32("counter");
            return View();
        }

        [HttpGet("generatePass")]
        public IActionResult makeNewPasscode()
        {
            string chars="ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            var rand = new Random();
            string newPasscode="";
            for(int i=0; i<15; i++)
            {
                newPasscode+= chars[rand.Next(36)];
            }
            HttpContext.Session.SetString("code", newPasscode);
            HttpContext.Session.SetInt32("counter", (int)HttpContext.Session.GetInt32("counter")+1);
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
