using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Middleware_ThumbnailGenerator_And_UploadFile.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Middleware_ThumbnailGenerator_And_UploadFile.Controllers
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


            return View();
        }


        public IActionResult PictureGallery()
        {

            var pfad = AppDomain.CurrentDomain.GetData("BildVerzeichnis") + @"\images\";

            string[] Bilder = Directory.GetFiles(pfad);

            return View(Bilder);
        }

        public IActionResult ConvertedPictureGallery()
        {

            var pfad = AppDomain.CurrentDomain.GetData("BildVerzeichnis") + @"\images\";

            string[] Bilder = Directory.GetFiles(pfad);

            return View(Bilder);
        }



        //Get-Methode
        public IActionResult PictureUpload()
        {
            return View(); 
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult PictureUpload(IFormFile datei)
        {
            FileInfo fileInfo = new FileInfo(datei.FileName);
            
            var pfad = AppDomain.CurrentDomain.GetData("BildVerzeichnis") + @"\images\" + fileInfo.Name;

            using (var fs = new FileStream(pfad, FileMode.Create))
            { 
                datei.CopyTo(fs); 
            }
            return RedirectToAction("Index");
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
