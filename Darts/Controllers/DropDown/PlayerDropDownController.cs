using Microsoft.AspNetCore.Mvc;
using Darts.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Darts.Controllers.DropDown
{
    public class PlayerDropDownController : Controller
    {
        private DartsContext _playerContext;

        public PlayerDropDownController(DartsContext playerContext)
        {
            _playerContext = playerContext;
        }

        public IActionResult Index()
        {
            var players = _playerContext.Player.OrderBy(p => p.FirstName).Select(x => new { Id = x.ID, Value = x.FirstName});
            var model = new Match
            {
                PlayerList = new SelectList(players, "Id", "Value")
            };

            return View(model);


            //List<Player> playerList = new List<Player>();
            //playerList = _playerContext.Player.ToList();
            //ViewBag.listofitems = playerList;

            //return View();
        }
    }
}