using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OverviewMVC.Controllers
{
    public class BasicController : Controller
    {
        public IActionResult Index() //Get-Methode
        {
           //Steht eigentlich in einem Post-Action Methode:  RedirectToAction("Index", "Home"); //Navigationen zu 
            return View();
        }
    }
}
