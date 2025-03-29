using Microsoft.AspNetCore.Mvc;
using vuePartielle.Models;

namespace DemoRoutes.Controllers
{


    [Route("demonstration/[controller]/[action]")]
    public class DemoController : Controller
    {
        private static List<Planete> planetes = new List<Planete>()
        {
            new Planete("mercure.png", 1, "Mercure", 87, 0.4, 2439, 58),
            new Planete("venus.png",2, "Vénus",224.7, 0.7, 6051.8,243 ),
            new Planete("terre.png",3, "Terre",365.25, 1, 6378.1,0.997 )
        };

        //[HttpGet("planetes/{id}")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
