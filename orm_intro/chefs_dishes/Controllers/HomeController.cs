using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using chefs_dishes.Models;
using Microsoft.EntityFrameworkCore;

namespace chefs_dishes.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private MyContext _context;

        public HomeController(ILogger<HomeController> logger, MyContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            List<Chef> allChefs = _context.Chefs.ToList();
            ViewBag.allChefs = allChefs;
            return View();
        }

        [HttpGet("addChef")]
        public IActionResult NewChef()
        {
            return View("NewChef");
        }

        [HttpPost("createChef")]
        public IActionResult createChef(Chef newChef)
        {
            if(newChef.DateOfBirth > DateTime.Today){
                ModelState.AddModelError("DateOfBirth", "Date must be a date from the past.");
            }
            if(ModelState.IsValid)
            {
                _context.Add(newChef);
                _context.SaveChanges();
            } else {
                return View("NewChef");
            }
            return RedirectToAction("Index");
        }

        [HttpGet("dishes")]
        public IActionResult allDishes()
        {
            ViewBag.allDishes = _context.Dishes.Include(d=>d.Creator).ToList();
            return View("Dishes");
        }

        [HttpGet("dishes/new")]
        public IActionResult NewDish()
        {
            ViewBag.allChefs = _context.Chefs.ToList();
            return View();
        }

        [HttpPost("addDish")]
        public IActionResult addDish(Dish newDish)
        {
            if(ModelState.IsValid)
            {
                _context.Add(newDish);
                _context.SaveChanges();
            } else {
                ViewBag.allChefs = _context.Chefs.ToList();
                return View("NewDish");
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
