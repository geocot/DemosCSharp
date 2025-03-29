using System.Diagnostics;
using DemoRoutes.Models;
using Microsoft.AspNetCore.Mvc;
using vuePartielle.Models;

namespace DemoRoutes.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private static List<Planete> planetes = new List<Planete>()
        {
            new Planete("mercure.png", 1, "Mercure", 87, 0.4, 2439, 58),
            new Planete("venus.png",2, "Vénus",224.7, 0.7, 6051.8,243 ),
            new Planete("terre.png",3, "Terre",365.25, 1, 6378.1,0.997 )
        };


        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        
        public IActionResult Index(int id)
        {
            return View(planetes[id - 1]);
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
