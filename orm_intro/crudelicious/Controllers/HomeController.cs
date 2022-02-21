using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using crudelicious.Models;
using Microsoft.EntityFrameworkCore;

namespace crudelicious.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private MyContext _context;

        public HomeController(ILogger<HomeController> logger, MyContext context)
        {
            _logger = logger;
            _context=context;
        }

        public IActionResult Index()
        {
            List<Dish> allDishes = _context.Dishes.ToList();
            ViewBag.allDishes = allDishes;
            return View();
        }

        [HttpGet("new")]
        public IActionResult NewDish()
        {
            return View("New");
        }

        [HttpPost("addDish")]
        public IActionResult addDish(Dish newDish)
        {
            if(ModelState.IsValid)
            {
                _context.Add(newDish);
                _context.SaveChanges();
            } else {
                return View("new");
            }
            return RedirectToAction("Index");
        }

        [HttpGet("{id}")]
        public IActionResult ViewDish(int id)
        {
            Dish singleDish = _context.Dishes.SingleOrDefault(d => d.DishId == id);
            ViewBag.singleDish = singleDish;
            return View("SingleDish");
        }

        [HttpGet("edit/{id}")]
        public IActionResult EditDish(int id)
        {
            Dish dishToEdit = _context.Dishes.FirstOrDefault(d => d.DishId == id);
            ViewBag.dishToEdit = dishToEdit;
            return View("EditDish", dishToEdit);
        }

        [HttpPost("update/{dishID}")]
        public IActionResult updateOne(int dishID, Dish editedDish)
        {
            Dish original = _context.Dishes.FirstOrDefault(d=>d.DishId==dishID);
            original.Chef = editedDish.Chef;
            original.Name = editedDish.Name;
            original.Calories = editedDish.Calories;
            original.Tastiness = editedDish.Tastiness;
            original.Description = editedDish.Description;
            original.UpdatedAt = DateTime.Now;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet("delete/{id}")]
        public IActionResult DeleteDish(int id)
        {
            Dish DeletingDish = _context.Dishes.SingleOrDefault(d => d.DishId == id);
            _context.Dishes.Remove(DeletingDish);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
