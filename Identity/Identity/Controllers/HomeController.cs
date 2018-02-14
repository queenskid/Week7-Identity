using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Identity.Models;

namespace Identity.Controllers
{
    //main controller built by the template
    public class HomeController : Controller
    {
        //return to index view
        public IActionResult Index()
        {
            return View();
        }
        //about view redirect
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
        //contact page view redirect?
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        //return an error page if view did not meet queue
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
