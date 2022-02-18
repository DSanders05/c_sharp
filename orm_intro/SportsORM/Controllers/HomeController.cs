using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsORM.Models;


namespace SportsORM.Controllers
{
    public class HomeController : Controller
    {

        private static Context _context;

        public HomeController(Context DBContext)
        {
            _context = DBContext;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.BaseballLeagues = _context.Leagues
                .Where(l => l.Sport.Contains("Baseball"))
                .ToList();
            return View();
        }

        [HttpGet("level_1")]
        public IActionResult Level1()
        {
            ViewBag.WomensLeagues = _context.Leagues.Where(w => w.Name.Contains("Womens'")).ToList();

            ViewBag.HockeyLeagues = _context.Leagues.Where(w => w.Sport.Contains("Hockey")).ToList();

            ViewBag.notFootballLeagues = _context.Leagues.Where(w => w.Sport != "Football").ToList();

            ViewBag.ConferenceLeagues = _context.Leagues.Where(w => w.Name.Contains("Conference")).ToList();

            ViewBag.AtlanticLeagues = _context.Leagues.Where(w => w.Name.Contains("Atlantic")).ToList();

            ViewBag.DallasBased = _context.Teams.Where(w => w.Location.Contains("Dallas")).ToList();

            ViewBag.Raptors = _context.Teams.Where(w => w.TeamName.Contains("Raptors")).ToList();

            ViewBag.CityLocation = _context.Teams.Where(w => w.Location.Contains("City")).ToList();
            
            ViewBag.BeginsWithT = _context.Teams.Where(w => w.TeamName.StartsWith("T")).ToList();
            
            ViewBag.TeamsAlphLocation = _context.Teams.OrderBy(t => t.Location).ToList();
            
            ViewBag.TeamNameDesc = _context.Teams.OrderByDescending(t => t.TeamName).ToList();

            ViewBag.lastCooper = _context.Players.Where(t => t.LastName == "Cooper").ToList();

            ViewBag.firstJoshua = _context.Players.Where(t => t.FirstName == "Joshua").ToList();

            ViewBag.CooperNotJoshua = _context.Players.Where(t => t.LastName == "Cooper" && t.FirstName != "Joshua").ToList();

            ViewBag.AlexOrWyatt = _context.Players.Where(t => t.FirstName == "Alexander" || t.FirstName == "Wyatt").ToList();

            return View();
        }

        [HttpGet("level_2")]
        public IActionResult Level2()
        {
            return View();
        }

        [HttpGet("level_3")]
        public IActionResult Level3()
        {
            return View();
        }

    }
}