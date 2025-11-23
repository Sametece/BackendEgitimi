using System;
using AutoMapper;
using ECommerce.Business.DTOs;
using ECommerce.Data.Models;

namespace ECommerce.Business.Mapping;

public class MappingProfile :Profile
{
    
    public MappingProfile()
    {
        CreateMap<Customer,CustomerDto>().ReverseMap();
        CreateMap<CreateCustomerDto,Customer>();
        
    }
}
