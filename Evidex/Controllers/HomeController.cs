using Evidex.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Evidex.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Search()
        {
            return View();
        }

        public IActionResult Map()
        {
            return View();
        }

        public IActionResult Statistics()
        {
            return View();
        }

        public IActionResult Authors()
        {
            return View();
        }

        public IActionResult Publishers()
        {
            return View();
        }

        public IActionResult Profile()
        {
            return View();
        }

        public IActionResult Logout()
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