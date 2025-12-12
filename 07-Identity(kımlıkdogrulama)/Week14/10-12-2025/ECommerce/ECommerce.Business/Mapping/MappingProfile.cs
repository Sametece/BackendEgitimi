using System;
using AutoMapper;
using ECommerce.Business.DTOs;
using ECommerce.Entity.Concrete;

namespace ECommerce.Business.Mapping;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        #region Category
        CreateMap<Category, CategoryDto>();
        CreateMap<CategoryCreateDto, Category>();
        CreateMap<CategoryUpdateDto, Category>();
        #endregion

        #region Product
        CreateMap<Product, ProductDto>()
            .ForMember(
                dest => dest.Categories,
                opt => opt.MapFrom(src => src.ProductCategories.Select(pc => pc.Category)));
        CreateMap<ProductCreateDto, Product>();
        CreateMap<ProductUpdateDto, Product>();
        #endregion

        #region Order/OrderItem
        CreateMap<Order,OrderDto>();
        CreateMap<OrderNowDto,OrderDto>();
        CreateMap<OrderItem,OrderItemDto>()
            .ForMember(
                dest=>dest.ProductName,
                opt=>opt.MapFrom(src=>src.Product!.Name))
            .ForMember(
                dest=>dest.ProductImageUrl,
                opt=>opt.MapFrom(src=>src.Product!.ImageUrl));
        #endregion
    }
}
