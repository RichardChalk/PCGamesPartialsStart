using Microsoft.AspNetCore.Mvc;
using PCGamesPartials.Data;
using PCGamesPartials.Models;

namespace PCGamesPartials.Controllers
{
    public class GameController : Controller
    {
        private readonly GameDbContext _dbContext;

        public GameController(GameDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var allGames = _dbContext.PCGames.ToList();
            return View(allGames);
        }
    }
}
