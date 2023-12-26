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
    public class OrderDetailManager:BaseManager<OrderDetailDTO,OrderDetail>,IOrderDetailManager
    {
        IOrderDetailRepository _orDetRep;
        IMapper _mapper;

        protected OrderDetailManager(IOrderDetailRepository iRep, IMapper mapper) : base(iRep, mapper)
        {
            _orDetRep = iRep;
            _mapper = mapper;
        }
    }
}
