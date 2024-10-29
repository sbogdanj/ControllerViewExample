using Microsoft.AspNetCore.Mvc;

namespace ControllerViewExample.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Links() 
        {
            return View();
        }
    }
}
