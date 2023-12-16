using AutoMapper;
using EShop.BLL.DTOs.DTOClasesses;
using EShop.BLL.ManagerServices.Abstracts;
using EShop.DAL.Repositories.Abstracts;
using EShop.ENTITIES.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SignInResult = Microsoft.AspNetCore.Identity.SignInResult;

namespace EShop.BLL.ManagerServices.Concretes
{
    public class AppUserManager:BaseManager<AppUserDTO,AppUser>,IAppUserManager
    {
        IAppUserRepository _appUseRep;
        IMapper _mapper;
        readonly UserManager<AppUser> _appUserManager;
        readonly SignInManager<AppUser> _signInManager;
        public AppUserManager(IAppUserRepository appUserRep, IMapper mapper, UserManager<AppUser> appUserManager, SignInManager<AppUser> signInManager) : base(appUserRep, mapper)
        {
            _appUseRep = appUserRep;
            _mapper = mapper;
            _appUserManager = appUserManager;
            _signInManager = signInManager;
        }

        public async Task<string> AddUser(AppUserDTO appUserDTO) //Testler Yapılacak metotlar yazılacak !!
        {

            AppUser user = new AppUser()
            {
                 UserName = appUserDTO.UserName,
                 Email = appUserDTO.Email,
            };

            IdentityResult result = await _appUserManager.CreateAsync(user,appUserDTO.Password);

            if(result.Succeeded)
            {
                await _appUserManager.AddToRoleAsync(user, "Member");
                return user.Id.ToString();
            }
            else if(!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    if (error.Description.Contains("Email"))
                    {
                        return "Email";
                    }
                    else if (error.Description.Contains("UserName"))
                    {
                        return "UserName";
                    }
                    else
                    {
                        return "Fail";
                    }
                }
            }
            return "Fail";

        }



        public async Task<string> LoginUser(AppUserDTO appUserDTO)
        {
            AppUser appUser = await _appUserManager.FindByNameAsync(appUserDTO.UserName);
            if (appUser == null)
            {
                return "NoFound";
            }
            SignInResult result = await _signInManager.PasswordSignInAsync(appUser, appUserDTO.Password,true,true);

            if (result.Succeeded) //Todo: Yeni Role Olur ise buraya ekleme yap string donen degerlere göre Controller'a yaz
            {
                IList<string> role = await _appUserManager.GetRolesAsync(appUser);
                if (role.Contains("Admin"))
                {
                    return "Admin";
                }
                else if (role.Contains("Member"))
                {
                    return "Member";
                }
                else if (role.Contains("Seller"))
                {
                    return "Seller";
                }
            }
            else if (result.IsNotAllowed)//Mail onayı lazım
            {
                return "MailPanel";
            }
            return "NoFound";
        }
    }
}
