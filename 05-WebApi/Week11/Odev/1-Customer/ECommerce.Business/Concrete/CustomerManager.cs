using System;
using AutoMapper;
using ECommerce.Business.Abstract;
using ECommerce.Business.DTOs;
using ECommerce.Business.DTOs.ResponseDtos;
using ECommerce.Data.Abstract;
using ECommerce.Data.Models;

namespace ECommerce.Business.Concrete;
public class CustomerManager : ICustomerService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public CustomerManager(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    // GET ALL
    public async Task<ResponseDto<IEnumerable<CustomerDto>>> GetCustomerAllAsync()
    {
        var customers = await _unitOfWork.Customers.GetAllAsync();
        if(!customers.Any())
        {
            return ResponseDto<IEnumerable<CustomerDto>>.Fail("Hiç Customer Bulunamadı",400);
        }

        var customerDtos = _mapper.Map<IEnumerable<CustomerDto>>(customers);

        return ResponseDto<IEnumerable<CustomerDto>>.Success(customerDtos, 200);
    }

    // GET BY ID
    public async Task<ResponseDto<CustomerDto>> GetCustomerByIdAsyc(int id)
    {
        var customer = await _unitOfWork.Customers.GetByIdAsync(id);

        if (customer == null)
            return ResponseDto<CustomerDto>.Fail("Müşteri bulunamadı", 404);

        var dto = _mapper.Map<CustomerDto>(customer);

        return ResponseDto<CustomerDto>.Success(dto, 200);
    }

    // CREATE
    public async Task<ResponseDto<CustomerDto>> CreateCustomerAsync(CreateCustomerDto createCustomerDto)
    {
        var customer = _mapper.Map<Customer>(createCustomerDto);
        await _unitOfWork.Customers.AddAsync(customer);
        await _unitOfWork.CompleteAsync();

        var dto = _mapper.Map<CustomerDto>(customer);

        return ResponseDto<CustomerDto>.Success(dto, 201);
    }

    // UPDATE
    public async Task<ResponseDto<NoContentDto>> UpdateAsync(int id, CreateCustomerDto createCustomerDto)
    {
        var customer = await _unitOfWork.Customers.GetByIdAsync(id);

        if (customer == null)
            return ResponseDto<NoContentDto>.Fail("Müşteri bulunamadı", 404);

        _mapper.Map(createCustomerDto, customer);

        _unitOfWork.Customers.Update(customer);
        await _unitOfWork.CompleteAsync();

        return ResponseDto<NoContentDto>.Success(204);
    }

    // DELETE
    public async Task<ResponseDto<NoContentDto>> DeleteAsync(int id)
    {
        var customer = await _unitOfWork.Customers.GetByIdAsync(id);

        if (customer == null)
            return ResponseDto<NoContentDto>.Fail("Müşteri bulunamadı", 404);

        _unitOfWork.Customers.Remove(customer);
        await _unitOfWork.CompleteAsync();

        return ResponseDto<NoContentDto>.Success(204);
    }
}



