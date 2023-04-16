using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Application.ServiceAbstractions;
using MyPortfolio.Core.Interfaces;
using MyPortfolio.Core.Models;
using MyPortfolio.Presentation.Models;
using System.Diagnostics;

namespace MyPortfolio.Presentation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IJobPositionService _jobPositionService;

        public HomeController(
                ILogger<HomeController> logger,
                IJobPositionService jobPositionService
            )
        {
            _logger = logger;
            _jobPositionService = jobPositionService;
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

        public async Task<IActionResult> Resume()
        {
            var resumes = await _jobPositionService.GetAll();
            object model = new { 
                    Resumes = resumes
                };

            return View(model);
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