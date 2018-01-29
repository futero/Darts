using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Darts.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Darts.Controllers
{
    public class HomeController : Controller
    {
        private DartsContext _context;

        public HomeController(DartsContext context)
        {
            this._context = context;
        }

        public IActionResult Index()
        {
            var players = _context.Player.OrderBy(p => p.FirstName).Select(x => new { Id = x.ID, Value = x.FirstName });
            var gameTypes = _context.GameType.OrderBy(g => g.Name).Select(x => new { Id = x.ID, Value = x.Name });

            var model = new Match
            {
                PlayerList = new SelectList(players, "Id", "Value"),
                GameTypeList = new SelectList(gameTypes, "Id", "Value")
            };
            
            return View(model);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Create()
        {
            Match match = new Match();
           // match.NrOfSets = HttpContext.Request.Form["NrOfSets"];

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
