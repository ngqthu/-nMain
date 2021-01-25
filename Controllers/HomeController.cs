using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TestWebsite.Models;

namespace TestWebsite.Controllers
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

        public IActionResult AboutUs()
        {
            return View();
        }
             public IActionResult Contact()
        {
            return View();
        }

         public IActionResult Menu()
           {
            return View();
           }
         public IActionResult Culture()
        {
            return View();
        }
         public IActionResult News()
        {
            return View();
        }
        public IActionResult Reservation()
        {
            return View();
        }
        public IActionResult Recommendation()
        {
            return View();
        }
        public IActionResult Gallery()
        {
            return View();
        }
        public IActionResult DoAn()
        {
            return View();
        }

        public IActionResult Combo()
        {
            return View();
        }
        public IActionResult DoUong()
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
