using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UpdateNomina.Models;

namespace UpdateNomina.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IWebHostEnvironment _webHostEnvironment;
        public HomeController(ILogger<HomeController> logger)
        {

            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}