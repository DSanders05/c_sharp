using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using wedding_planner.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace wedding_planner.Controllers
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
            return View();
        }

        [HttpPost("register")]
        public IActionResult Register(User newUser)
        {
            if(ModelState.IsValid)
            {
                if(_context.Users.Any(u=>u.Email == newUser.Email))
                {
                    ModelState.AddModelError("Email", "Email already in use!");
                    return View("Index");
                }
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                newUser.Password = Hasher.HashPassword(newUser, newUser.Password);
                _context.Users.Add(newUser);
                _context.SaveChanges();
                HttpContext.Session.SetInt32("UserId",newUser.UserId);
                return RedirectToAction("Dashboard");
            } else {
                return View("Index");
            }
        }

        [HttpPost("login")]
        public IActionResult Login(LogUser logUser)
        {
            if(ModelState.IsValid)
            {
                User userInDB = _context.Users.FirstOrDefault(s=>s.Email == logUser.LEmail);
                if(userInDB == null)
                {
                    ModelState.AddModelError("LEmail", "Invalid login attempt");
                    return View("Index");
                }
                PasswordHasher<LogUser> Hasher = new PasswordHasher<LogUser>();
                PasswordVerificationResult result = Hasher.VerifyHashedPassword(logUser, userInDB.Password, logUser.LPassword);
                if(result == 0)
                {
                    ModelState.AddModelError("LEmail", "Invalid login attempt");
                    return View("Index");
                }
                HttpContext.Session.SetInt32("UserId", userInDB.UserId);
                return RedirectToAction("Dashboard");
            } else {
                return View("Index");
            }
        }

        [HttpGet("Dashboard")]
        public IActionResult Dashboard()
        {
            ViewBag.userInfo = HttpContext.Session.GetInt32("UserId");
            ViewBag.allWeddings = _context.Weddings.Include(a=>a.Attendees).ThenInclude(b=>b.Attendee).OrderBy(b=>b.Date).ToList();
            return View("Dashboard");
        }

        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return View("Index");
        }

        [HttpGet("/delete/{wid}")]
        public IActionResult Delete(int wid)
        {
            Wedding wedding = _context.Weddings.SingleOrDefault(w=>w.WeddingId == wid);
            _context.Weddings.Remove(wedding);
            _context.SaveChanges();
            return Redirect("/Dashboard");
        }

        [HttpGet("/uninvite/{wid}/{uid}")]
        public IActionResult Uninvite(int wid, int uid)
        {
            Association removedAssn = _context.Associations.SingleOrDefault(a=>a.UserId == uid && a.WeddingId == wid);
            _context.Associations.Remove(removedAssn);
            _context.SaveChanges();
            return Redirect("/Dashboard");
        }

        [HttpGet("NewWedding")]
        public IActionResult NewWedding()
        {   
            ViewBag.userInfo = HttpContext.Session.GetInt32("UserId");
            return View();
        }

        [HttpGet("/rsvp/{wid}/{uid}")]
        public IActionResult RSVP(int wid, int uid)
        {
            Association newAssn = new Association();
            newAssn.WeddingId=wid;
            newAssn.UserId=uid;
            _context.Associations.Add(newAssn);
            _context.SaveChanges();
            return Redirect($"/viewWedding/{wid}");
        }

        [HttpPost("planWedding")]
        public IActionResult PlanWedding(Wedding newWedding)
        {
            if(ModelState.IsValid)
            {
                _context.Weddings.Add(newWedding);
                _context.SaveChanges();
                return Redirect($"/viewWedding/{newWedding.WeddingId}");
            } else {
                return View("NewWedding");
            }
        }

        [HttpGet("/viewWedding/{wid}")]
        public IActionResult ViewWedding(int wid)
        {
            Wedding wed = _context.Weddings.Include(a=>a.Attendees).ThenInclude(b=>b.Attendee).FirstOrDefault(w=>w.WeddingId == wid);
            ViewBag.wedding = wed;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
