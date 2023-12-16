using EShop.BLL.DTOs.DTOClasesses;
using EShop.ENTITIES.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.BLL.ManagerServices.Abstracts
{
    public interface IAppUserManager:IManager<AppUserDTO,AppUser>
    {
        public Task<string> AddUser(AppUserDTO appUser);
        public Task<string> LoginUser(AppUserDTO appUserDTO);
    }
}
