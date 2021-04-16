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
            ViewBag.WomensLeagues=_context.Leagues.Where(sport=>sport.Sport.Contains("Women's")).ToList();
            ViewBag.Hockey=_context.Leagues.Where(t=>t.Sport.Contains("Hockey")).ToList();
            ViewBag.NotFootball=_context.Leagues.Where(NotFootball =>NotFootball.Sport !="football").ToList();
            ViewBag.Conference=_context.Leagues.Where(Conference =>Conference.Name.Contains("Conference")).ToList();
            ViewBag.Atlantic=_context.Leagues.Where(Atlantic => Atlantic.Name.Contains("Atlantic")).ToList();
            ViewBag.Dallas=_context.Teams.Where(teams=>teams.Location.Contains("Dallas")).ToList();
            ViewBag.Raptors=_context.Teams.Where(Raptors =>Raptors.TeamName.Contains("Raptors")).ToList();
            ViewBag.City=_context.Teams.Where(City =>City.Location.Contains("City")).ToList();
            ViewBag.T=_context.Teams.Where(team =>team.TeamName.StartsWith("T")).ToList();
            ViewBag.Alphabetically= _context.Teams.OrderBy(Alphabetically => Alphabetically.Location).ToList();
            ViewBag.ReverseAlphabetical= _context.Teams.OrderByDescending(ReverseAlph=>ReverseAlph.TeamName).ToList();
            ViewBag.Cooper=_context.Players.Where(C=>C.LastName.Contains("Cooper")).ToList();
            ViewBag.Joshua = _context.Players.Where(J=>J.FirstName.Contains("Joshua")).ToList();
            ViewBag.CooperToJoshua =_context.Players.Where(CJ => CJ.LastName.Contains("Cooper")&& !CJ.FirstName.Contains("Joshua")).ToList();
            ViewBag.AlexanderWyatt=_context.Players.Where(AW =>AW.FirstName.Contains("Alexander")||AW.FirstName.Contains("Wyatt")).ToList();
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