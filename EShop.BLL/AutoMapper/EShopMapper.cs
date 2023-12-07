using AutoMapper;
using EShop.BLL.DTOs.DTOClasesses;
using EShop.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.BLL.AutoMapper
{
    public class EShopMapper : Profile
    {
        public EShopMapper()
        {
            CreateMap<CategoryDTO, Category>().ReverseMap();

            CreateMap<Category, CategoryDTO>()
                .ForMember(dest => dest.CategoryName, act => act.MapFrom(src => src.CategoryName))
                .ForMember(dest => dest.Description, act => act.MapFrom(src => src.Description))
                .ForMember(dest => dest.CreatedDate, act => act.MapFrom(src => src.CreatedDate))
                .ForMember(dest => dest.ModifiedDate, act => act.MapFrom(src => src.ModifiedDate))
                .ForMember(dest => dest.DeletedDate, act => act.MapFrom(src => src.DeletedDate))
                .ForMember(dest => dest.Status, act => act.MapFrom(src => src.Status))
                .ForMember(dest => dest.ID, act => act.MapFrom(src => src.ID))
                .ReverseMap();



        }

    }
}
