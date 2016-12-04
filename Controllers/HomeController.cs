using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace amat_project.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Formation()
        {
            ViewData["Message"] = "Notre catalogue de formations.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Nous contacter";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
