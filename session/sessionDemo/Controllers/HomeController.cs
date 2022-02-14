using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using sessionDemo.Models;
using Microsoft.AspNetCore.Session;

namespace sessionDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            if(HttpContext.Session.GetString("playerChoice"==null))
            {
                HttpContext.Session.SetString("playerChoice", "~/images/l-rock.png");
            }
            ViewBag.PlayerChoice = HttpContext.Session.GetString("playerChoice");
            return View();
        }

        [HttpGet("player/{choice}")]
        public IActionResult playerChoice(string choice)
        {
            // We need an array of choices
            // Then we need to randomly pick one
            var rand = new Random();
            string[] compChoices={"rock","paper","scissors"};
            string compChoice = compChoices[rand.Next(3)];
            // Console.WriteLine($"Your computer choice is {compChoices[rand.Next(3)]}");
            Console.WriteLine($"You picked {choice}");
            string imgChoice = $"~/images/l-{choice}.png";
            Console.WriteLine(imgChoice);
            HttpContext.Session.SetString("playerChoice", imgChoice);
            // Logic where we figure out who won
            if(choice == "paper" && compChoices[rand.Next(3)]=="scissors")
            {
                Console.WriteLine("You lost!");
            }
            else if(choice == "paper" && compChoices[rand.Next(3)]=="rock")
            {
                Console.WriteLine("You win!");
            }
            else if(choice == "paper" && compChoices[rand.Next(3)]=="paper")
            {
                Console.WriteLine("Draw!");
            }
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
