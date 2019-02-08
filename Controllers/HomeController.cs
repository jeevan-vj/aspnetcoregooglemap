using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using googlemap.Models;

namespace googlemap.Controllers
{
    public class SampleModal{
       public string lat {get; set;}
       public string lon {get; set;}
    }
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var modal = new List<SampleModal>{
                new SampleModal { lat = "-34.39784494644985", lon = "150.57861328125003" }, 
                new SampleModal { lat = "-34.35250666867595", lon = "150.68847656250003" }, 
            };
            ViewBag.Locations = modal;
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
