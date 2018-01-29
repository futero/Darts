using Microsoft.AspNetCore.Mvc;
using Darts.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Darts.Controllers.DropDown
{
    public class GameTypeDropDownController : Controller
    {
        private DartsContext _context;

        public GameTypeDropDownController(DartsContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var gameTypes = _context.GameType.OrderBy(g => g.Name).Select(x => new { Id = x.ID, Value = x.Name });
            var model = new Match
            {
                GameTypeList = new SelectList(gameTypes, "Id", "Value")
            };

            return View(model);
        }
    }
}