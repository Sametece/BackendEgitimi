using System;
using AutoMapper;
using ECommerce.Business.DTOs;
using ECommerce.Entity.Concrete;

namespace ECommerce.Business.Mapping;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Category, CategoryDto>();
        CreateMap<CategoryCreateDto,Category>();
        CreateMap<CategoryUpdateDto,Category>();

        CreateMap<Product, ProductDto>();
        CreateMap<ProductCreateDto, Product>();
        CreateMap<ProductUpdateDto, Product>();
    }
}
