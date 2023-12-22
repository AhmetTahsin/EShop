using Microsoft.AspNetCore.Mvc;

namespace EShop.COREMVC.Areas.Member.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
