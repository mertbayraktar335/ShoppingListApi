using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using TeleperformanceProject.ShoppingList.Application.DTOs;
using TeleperformanceProject.ShoppingList.Domain.Entities;
using TeleperformanceProject.ShoppingList.Domain.Entities.Enums;

namespace TeleperformanceProject.ShoppingList.Application.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductDto>()
                .ForMember(x => x.ProductName, x => x.MapFrom(x => x.Name))
                .ForMember(x => x.ProductQuantity, x => x.MapFrom(x => (x.QuantityName +" "+(Quantity)x.QuantityId).ToString()))
                .ForMember(x=> x.IsBought, x=> x.MapFrom(x=>x.IsBought));


            CreateProjection<Product, ProductListDto>()
            .ForMember(x => x.ProductName, x => x.MapFrom(x => x.Name))
            .ForMember(x => x.ProductQuantity, x => x.MapFrom(x => (x.QuantityName + " " +(Quantity) x.QuantityId).ToString()))
            .ForMember(x => x.IsBought, x => x.MapFrom(x => x.IsBought));

            CreateMap<ShoppList, ShopListAddDto>()
            .ForMember(x => x.Name, conf => conf.MapFrom(x => x.Name))
            .ForMember(x => x.UserId, conf => conf.MapFrom(x => x.UserId))
            .ForMember(x => x.Description, conf => conf.MapFrom(x => x.Description))
            .ForMember(x => x.CategoryId, conf => conf.MapFrom(x => x.CategoryId));


            CreateProjection<ShoppList, ShopListDto>()
            .ForMember(x => x.Name, conf => conf.MapFrom(x => x.Name))
            .ForMember(x=> x.CompletedDate, conf => conf.MapFrom(x=> x.CompletedDate))
            .ForMember(x => x.Description, conf => conf.MapFrom(x => x.Description))
            .ForMember(x => x.CategoryId, conf => conf.MapFrom(x => x.CategoryId));

            CreateMap<ShoppList, ShopListRemoveDto>()
                .ForMember(x => x.Name, y => y.MapFrom(x => x.Name))
                .ForMember(x => x.Description, y => y.MapFrom(x => x.Description))
                .ForMember(x => x.CreatedDate, y => y.MapFrom(x => x.CreatedDate));

            CreateMap<ShoppList, ShopListUpdateDto>()
            .ForMember(x => x.Name, conf => conf.MapFrom(x => x.Name))
            .ForMember(x => x.IsCompleted, conf => conf.MapFrom(x => x.IsCompleted))
            .ForMember(x => x.Description, conf => conf.MapFrom(x => x.Description));
            




        }
    }
}
