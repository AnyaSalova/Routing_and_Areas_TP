using System.Diagnostics;
using LW07_TP.Models;
using Microsoft.AspNetCore.Mvc;

namespace LW07_TP.Controllers
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Start()
        {
            return View();
        }

        public IActionResult Start0(string? uvar)
        {
            string result = string.IsNullOrEmpty(uvar) ? "Пользовательская переменная не задана" : uvar;
            return View("StrictView", result);
        }
    }
}
