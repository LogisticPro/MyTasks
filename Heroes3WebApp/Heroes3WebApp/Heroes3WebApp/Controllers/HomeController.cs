﻿using Heroes3WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Heroes3WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //var list = db.Landscapes.ToList();
            //string result = "";
            //foreach (var item in list)
            //{
            //    result += $"{item.Id} {item.Name}";
            //}
            //ViewData["List"] = result;
            return View();
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