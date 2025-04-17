using System.Diagnostics;
using DemoSemaine11.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoSemaine11.Controllers
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

        public IActionResult FormulaireArbre()
        {
            return View();
        }

        [HttpPost]
        public IActionResult FormulaireReception(Arbre arbre)
        {
            return View("RecFormulaire", arbre);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
