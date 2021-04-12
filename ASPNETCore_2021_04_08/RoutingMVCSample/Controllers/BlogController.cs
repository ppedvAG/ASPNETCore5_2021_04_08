using Microsoft.AspNetCore.Mvc;
using Microsoft.Docs.Samples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoutingMVCSample.Controllers
{
    //[Area("Blog")]
    public class BlogController : Controller
    {
        public IActionResult Article()
        {
            return View();
        }

        //[HttpGet("/blogv2/about")]
        [Route("/blogv2/about")]
        public IActionResult About()
        {
            //return View();
            return ControllerContext.MyDisplayRouteInfo();
        }
    }
}
