﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SnakesAndLadders.Models;
using SnakesAndLadders.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SnakesAndLadders.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IGameService _gameService;
        public HomeController(ILogger<HomeController> logger, IGameService gameService)
        {
            _logger = logger;
            _gameService = gameService;

        }

        public IActionResult Index()
        {
            return View(_gameService.DrawGame());
        }

        public int RollDice()
        {
            return _gameService.RollDice();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
