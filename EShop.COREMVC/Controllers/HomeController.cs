using EShop.BLL.DTOs.DTOClasesses;
using EShop.BLL.ManagerServices.Abstracts;
using EShop.COREMVC.Models;
using EShop.COREMVC.Models.PageModels.LoginUserModels;
using Microsoft.AspNetCore.Http.HttpResults;
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
        public async Task<IActionResult> LogIn(UserLoginPageVM model) //Todo:Beni Hat�rla K�sm� ayarlanacak !
        {
            AppUserDTO userDTO = new AppUserDTO()
            {
                UserName = model.User.UserName.ToLower(),
                Password = model.User.Password,
            };

            string result = await _appUserManager.LoginUser(userDTO); //Domain kullanmamak i�in string olarak d�nen deger ile i�lem yap�yorum
            if (result == "Admin")
            {
                return RedirectToAction("Index", "Home", new { Area = "Admin" }); //Test Edildi
            }
            else if (result == "Member")
            {
                return RedirectToAction("Index", "Home", new { Area = "Member" });
            }
            else if (result == "Seller")
            {
                return RedirectToAction("Index", "Seller", new { Area = "Seller" });
            }
            else if (result == "MailPanel")
            {
                TempData["message"] = "E-Posta adresiniz ile mailinizi onay�n�z...";
                return RedirectToAction("LogIn");
            }
            else if (result == "NoFound")
            {
                TempData["message"] = "UserName veya Password Hatal�...";
                return RedirectToAction("LogIn");
            }



            return View();
        }
    }
}
