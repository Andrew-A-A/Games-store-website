using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gamer.gg.Models;

namespace Gamer.gg.Controllers
{
    [Authorize]
    public class GameController : Controller
    {
        private ApplicationDbContext _context;

        public GameController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Game
        [Route("Game/Index/{genreId}")]
        public ActionResult Index(int genreId)
            {
                var games = _context.Games.Where(g=>g.genre ==genreId).ToList();
                return View(games);
        }
        [Route("Game/Details/{gameId}")]
        public ActionResult Details(int gameId)
        {
            var game = _context.Games.Single(g => g.Id == gameId);
            return View(game);
        }
        [Route("Game/Buy/{gameId}")]
        public ActionResult Buy(int gameId)
        {
            return View();
        }
    }
}