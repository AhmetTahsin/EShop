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
        public async Task<IActionResult> LogIn(UserLoginPageVM model) //Todo:Beni Hatýrla Kýsmý ayarlanacak !
        {
            AppUserDTO userDTO = new AppUserDTO()
            {
                UserName = model.User.UserName.ToLower(),
                Password = model.User.Password,
            };

            string result = await _appUserManager.LoginUser(userDTO); //Domain kullanmamak için string olarak dönen deger ile iþlem yapýyorum
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
                TempData["message"] = "E-Posta adresiniz ile mailinizi onayýnýz...";
                return RedirectToAction("LogIn");
            }
            #endregion
            #region Giriþ Baþarýsýz
            else if (result == "NoFound")
            {
                TempData["message"] = "UserName veya Password Hatalý...";
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
            var result = await _appUserManager.AddUser(appUserDTO); //Kullanýcý olusturup Member Rolunde user olustur string deger donecek
            
            if (result == "Fail") //  Kullanýcý olusamadý ise UserName ve Email harici bir hata da !
            {
                TempData["message"] = "Kullanýcý Olusamadý Site Yöneticisi ile iletiþime geçiniz";
                return RedirectToAction("Register");
            }
            else if (result == "UserName") 
            {
                TempData["message"] = "Kullanýcý Adý Daha Önce Alýnmýþ";
                return RedirectToAction("Register");
            }
            else if(result == "Email")
            {
                TempData["message"] = "Email Adresi Daha Önce Alýnmýþ";
                return RedirectToAction("Register");
            }
            else //Bir hata olmadý ise geriye string tipte bir sayý döndurecek id'yi ! result !
            {
                Guid specId = Guid.NewGuid();
                string subject = "EShop Mail Doðrulama";
                string body = $"Hesabýnýz olusturulmustur.Üyeliginizi onaylamak icin lütfen http://localhost:5012/Home/ConfirmEmail?specId={specId}&id={result} linkine týklayýnýz"; //olusturduðmuz link ile ConfirmEmail Actionuna gidecek þifreli bir þekilde 
                MailService.Send(model.RegisterModel.Email, body: body, subject: subject); //Mail Gönder

                TempData["Message"] = "Emailinizi kontrol ediniz";
                return RedirectToAction("Register");
            }

        }
    }
}
