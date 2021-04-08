using DI_BasicSample;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OverviewMVC.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace OverviewMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ICar _car; 


        public HomeController(ILogger<HomeController> logger, ICar car, MockCar heeeeelp)
        {
            _logger = logger;
            _car = car; 
        }

        public IActionResult Index() //https://localhost:12345/Home/Index 
        {
            return View();
        }

        public IActionResult Privacy() ////https://localhost:12345/Home/Privacy 
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
