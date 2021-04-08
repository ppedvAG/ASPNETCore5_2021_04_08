using ConfigurationInMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigurationInMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;

        private readonly SampleWebSettings _settings;

        public HomeController(ILogger<HomeController> logger, IConfiguration configuration, IOptions<SampleWebSettings> settingsOptions)
        {
            _logger = logger;
            _configuration = configuration;
            _settings = settingsOptions.Value;
        }

        public IActionResult Index()
        {
            PositionOptions positionOptions = new();
            _configuration.GetSection(PositionOptions.Position).Bind(positionOptions); //befüllt die AppSettings->Position: (Title/Name) in die Klaasse PositionOptions



            return Content($"Title: {positionOptions.Title} \n" +
                $"Name: {positionOptions.Name} ");
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
