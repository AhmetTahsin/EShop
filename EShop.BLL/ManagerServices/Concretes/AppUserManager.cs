using AutoMapper;
using EShop.BLL.DTOs.DTOClasesses;
using EShop.BLL.ManagerServices.Abstracts;
using EShop.DAL.Repositories.Abstracts;
using EShop.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.BLL.ManagerServices.Concretes
{
    public class AppUserManager:BaseManager<AppUserDTO,AppUser>,IAppUserManager
    {
        IAppUserRepository _appUseRep;
        IMapper _mapper;
        public AppUserManager(IAppUserRepository appUserRep,IMapper mapper):base(appUserRep,mapper)
        {
            _appUseRep = appUserRep;
            _mapper = mapper;
        }

        public bool AddUser(AppUserDTO appUser) //Testler Yapılacak metotlar yazılacak !!
        {

            return false;
        }
        public bool LoginUser(AppUserDTO appUser)
        {
            AppUser user = new AppUser()
            {
                UserName = appUser.UserName,
            };

            return false;
        }
    }
}
