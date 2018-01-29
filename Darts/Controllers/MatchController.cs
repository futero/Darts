using Darts.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Darts.Controllers
{
    public class MatchController : Controller
    {
        private readonly DartsContext _context;
        public MatchController(DartsContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            using (_context)
            {
                foreach (var player in _context.Player)
                {
                    Debug.WriteLine(player.FirstName + " " + "\"" + player.NickName + "\"" + " " + player.SurName);
                }
            }
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
