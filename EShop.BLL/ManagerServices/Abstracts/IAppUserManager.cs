using EShop.BLL.DTOs.DTOClasesses;
using EShop.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.BLL.ManagerServices.Abstracts
{
    public interface IAppUserManager:IManager<AppUserDTO,AppUser>
    {
        public bool AddUser(AppUserDTO appUser);
    }
}
