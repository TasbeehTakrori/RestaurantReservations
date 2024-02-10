﻿using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using RestaurantReservation.API.DTOs;
using RestaurantReservation.API.ViewModels;
using RestaurantReservation.Application.DTOs;
using RestaurantReservation.Application.Services.IServices;
using System.Text.Json;

namespace RestaurantReservation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        private readonly IValidator<PaginationInfo> _paginationInfoValidator;
        private readonly IValidator<EmployeeRequestDTO> _employeeRequestValidator;
        private readonly IOrderService _orderService;
        private readonly IMapper _mapper;

        public EmployeesController(
            IEmployeeService employeeService,
            IMapper mapper,
            IValidator<PaginationInfo> paginationInfoValidator,
            IValidator<EmployeeRequestDTO> employeeRequestValidator,
            IOrderService orderService)
        {
            _employeeService = employeeService;
            _mapper = mapper;
            _paginationInfoValidator = paginationInfoValidator;
            _employeeRequestValidator = employeeRequestValidator;
            _orderService = orderService;
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<EmployeeVM>> GetEmployee(int id)
        {
            var employee = await _employeeService.RetrieveEmployeeByIdAsync(id);
            return Ok(_mapper.Map<EmployeeVM>(employee));
        }

        [HttpGet]
        public async Task<ActionResult<CollectionVM<EmployeeVM>>> GetEmployees(
            [FromQuery] PaginationInfo paginationInfo)
        {
            await _paginationInfoValidator.ValidateAndThrowAsync(paginationInfo);

            (var employees, var paginationMetadata) = await _employeeService.RetrieveEmployeesAsync(
                paginationInfo.PageNumber, paginationInfo.PageSize);
            var employeeVMs = _mapper.Map<List<EmployeeVM>>(employees);

            var collectionVM = new CollectionVM<EmployeeVM>()
            {
                Count = employeeVMs.Count,
                Items = employeeVMs
            };

            Response.Headers.Add("X-Pagination",
              JsonSerializer.Serialize(paginationMetadata));
            return Ok(collectionVM);
        }

        [HttpPost]
        public async Task<ActionResult<EmployeeVM>> CreateEmployee([FromBody] EmployeeRequestDTO employeeRequestDTO)
        {
            await _employeeRequestValidator.ValidateAndThrowAsync(employeeRequestDTO);

            var employee = await _employeeService.CreateEmployeeAsync(_mapper.Map<EmployeeDTO>(employeeRequestDTO));
            return CreatedAtAction(
                nameof(GetEmployee),
                new { id = employee!.EmployeeId },
                _mapper.Map<EmployeeVM>(employee));
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> UpdateEmployee(
            int id, EmployeeRequestDTO employeeRequestDTO)
        {
            await _employeeRequestValidator.ValidateAndThrowAsync(employeeRequestDTO);
            await _employeeService.UpdateEmployeeAsync(id, _mapper.Map<EmployeeDTO>(employeeRequestDTO));

            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeleteEmployee(int id)
        {
            await _employeeService.DeleteEmployeeAsync(id);

            return NoContent();
        }

        [HttpGet("{id:int}/averageOrderAmount")]
        public async Task<ActionResult<decimal>> GetEmployeeAverageOrderAmountAsync(int id)
        {
            var averageOrderAmount = await _orderService.CalculateAverageOrderAmountAsync(id);
            return Ok(new { AverageOrderAmount = averageOrderAmount });
        }
    }
}
