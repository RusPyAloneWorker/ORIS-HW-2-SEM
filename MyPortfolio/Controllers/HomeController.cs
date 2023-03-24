using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models;
using System.Diagnostics;

namespace MyPortfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Hero()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Facts()
        {
            return View();
        }

        public IActionResult Skills()
        {
            return View();
        }

        public IActionResult Portfolio()
        {
            return View();
        }

        public IActionResult Resume()
        {
            return View();
        }

        public IActionResult Services()
        {
            return View();
        }

        public IActionResult Contact()
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