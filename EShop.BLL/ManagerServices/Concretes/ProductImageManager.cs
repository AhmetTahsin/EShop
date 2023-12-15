using AutoMapper;
using EShop.BLL.DTOs.DTOClasesses;
using EShop.DAL.Repositories.Abstracts;
using EShop.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.BLL.ManagerServices.Concretes
{
    public class ProductImageManager:BaseManager<ProductImageDTO,ProductImage>
    {
        IProductImageRepository _propImgRep;
        IMapper _mapper;
        public ProductImageManager(IProductImageRepository proImgRep,IMapper mapper):base(proImgRep,mapper)
        {
            _propImgRep = proImgRep;
            _mapper = mapper;
        }
    }
}
