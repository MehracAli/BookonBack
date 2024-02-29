using Microsoft.AspNetCore.Mvc;

namespace BookonMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
