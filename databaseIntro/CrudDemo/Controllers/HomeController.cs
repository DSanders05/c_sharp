using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CrudDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudDemo.Controllers
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
            // This gets all icecream instances in DB
            List<Icecream> allIcecream = _context.Icecream.ToList();
            ViewBag.allIcecreams = allIcecream;
            return View();
        }

        [HttpPost("process")]
        public IActionResult Process(Icecream newIcecream)
        {
            if(ModelState.IsValid)
            {
                Console.WriteLine("It worked");
                _context.Add(newIcecream);
                _context.SaveChanges();
                return RedirectToAction("Index");
            } else {
                return View("Index");
            }
        }

        [HttpGet("delete/{icid}")]
        public IActionResult deleteOne(int icid)
        {
            // Step one: find the thing we're trying to delete
            Icecream icToDelete = _context.Icecream.SingleOrDefault(a => a.IcecreamId == icid);
            _context.Icecream.Remove(icToDelete);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet("edit/{icid}")]
        public IActionResult editOne(int icid)
        {
            Icecream icToEdit = _context.Icecream.FirstOrDefault(a => a.IcecreamId == icid);
            return View("EditOne");
        }

        [HttpPost("update/{icid}")]
        public IActionResult updateOne(int icid, Icecream editedIcecream)
        {
            Icecream original = _context.Icecream.FirstOrDefault(a => a.IcecreamId == icid);
            original.Flavor = editedIcecream.Flavor;
            original.Topping = editedIcecream.Topping;
            original.hasCherry = editedIcecream.hasCherry;
            original.Container = editedIcecream.Container;
            original.UpdatedAt = DateTime.Now;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
