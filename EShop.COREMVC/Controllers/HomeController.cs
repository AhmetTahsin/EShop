using EShop.BLL.DTOs.DTOClasesses;
using EShop.BLL.ManagerServices.Abstracts;
using EShop.COREMVC.Models;
using EShop.COREMVC.Models.PageModels.LoginUserModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EShop.COREMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        readonly IAppUserManager _appUserManager;
        public HomeController(ILogger<HomeController> logger, IAppUserManager appUserManager)
        {
            _logger = logger;
            _appUserManager = appUserManager;
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

        public IActionResult LogIn()
        {
            return View();
        }
        [HttpPost]
        public IActionResult LogIn(UserLoginPageVM model)
        {
            AppUserDTO userDTO = new AppUserDTO()
            {
                UserName = model.User.UserName,
                Password = model.User.Password,
            };
            

            return View();
        }
    }
}
