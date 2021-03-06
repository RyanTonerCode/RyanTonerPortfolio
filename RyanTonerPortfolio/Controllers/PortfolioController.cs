﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RyanTonerPortfolio.Models;

namespace RyanTonerPortfolio.Controllers
{
    public class Portfolio : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SelfHelp()
        {
            return View();
        }

        public IActionResult TicTacBoom()
        {
            return View();
        }

        public IActionResult Assembly()
        {
            return View();
        }

        public IActionResult DASC()
        {
            return View();
        }

        public IActionResult FAA()
        {
            return View();
        }

        public IActionResult Derivative()
        {
            return View();
        }

        public IActionResult FifteenPuzzle()
        {
            return View();
        }

        public IActionResult Pathfinding()
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
