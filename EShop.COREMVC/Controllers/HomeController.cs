using EShop.BLL.DTOs.DTOClasesses;
using EShop.BLL.ManagerServices.Abstracts;
using EShop.COMMON.Tools;
using EShop.COREMVC.Models;
using EShop.COREMVC.Models.PageModels.LoginUserModels;
using EShop.COREMVC.Models.PageModels.RegisterUserModels;
using EShop.ENTITIES.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
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
            #region Rol Kontrol
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
            #endregion
            #region EMail Onay
            else if (result == "MailPanel")
            {
                TempData["message"] = "E-Posta adresiniz ile mailinizi onay�n�z...";
                return RedirectToAction("LogIn");
            }
            #endregion
            #region Giri� Ba�ar�s�z
            else if (result == "NoFound")
            {
                TempData["message"] = "UserName veya Password Hatal�...";
                return RedirectToAction("LogIn");
            } 
            #endregion

            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(UserRegisterPageVM model)
        {
            AppUserDTO appUserDTO = new AppUserDTO()
            {
                UserName=model.RegisterModel.UserName.ToLower(),
                Password=model.RegisterModel.Password,
                Email=model.RegisterModel.Email.ToLower(),
            };
            var result = await _appUserManager.AddUser(appUserDTO); //Kullan�c� olusturup Member Rolunde user olustur string deger donecek
            
            if (result == "Fail") //  Kullan�c� olusamad� ise UserName ve Email harici bir hata da !
            {
                TempData["message"] = "Kullan�c� Olusamad� Site Y�neticisi ile ileti�ime ge�iniz";
                return RedirectToAction("Register");
            }
            else if (result == "UserName") 
            {
                TempData["message"] = "Kullan�c� Ad� Daha �nce Al�nm��";
                return RedirectToAction("Register");
            }
            else if(result == "Email")
            {
                TempData["message"] = "Email Adresi Daha �nce Al�nm��";
                return RedirectToAction("Register");
            }
            else //Bir hata olmad� ise geriye string tipte bir say� d�ndurecek id'yi ! result !
            {
                Guid specId = Guid.NewGuid();
                string subject = "EShop Mail Do�rulama";
                string body = $"Hesab�n�z olusturulmustur.�yeliginizi onaylamak icin l�tfen http://localhost:5012/Home/ConfirmEmail?specId={specId}&id={result} linkine t�klay�n�z"; //olusturdu�muz link ile ConfirmEmail Actionuna gidecek �ifreli bir �ekilde 
                MailService.Send(model.RegisterModel.Email, body: body, subject: subject); //Mail G�nder

                TempData["Message"] = "Emailinizi kontrol ediniz";
                return RedirectToAction("Register");
            }

        }
    }
}
