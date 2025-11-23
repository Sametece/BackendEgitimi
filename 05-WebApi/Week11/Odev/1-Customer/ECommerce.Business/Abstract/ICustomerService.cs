using System;
using ECommerce.Business.DTOs;
using ECommerce.Business.DTOs.ResponseDtos;

namespace ECommerce.Business.Abstract;

public interface ICustomerService
{
   Task<ResponseDto<IEnumerable<CustomerDto>>> GetCustomerAllAsync();
   Task<ResponseDto<CustomerDto>> GetCustomerByIdAsyc(int id);

   Task<ResponseDto<CustomerDto>> CreateCustomerAsync(CreateCustomerDto createCustomerDto);
   Task<ResponseDto<NoContentDto>> UpdateAsync(int id , CreateCustomerDto createCustomerDto);
   Task<ResponseDto<NoContentDto>> DeleteAsync(int id);
}
