using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RyanTonerPortfolio.Models;

namespace RyanTonerPortfolio.Controllers
{
    public class Portfolio : Controller
    {
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
