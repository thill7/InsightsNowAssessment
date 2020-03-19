using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BingoRoom.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGame _game;

        public HomeController(IGame game)
        {
            _game = game;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
