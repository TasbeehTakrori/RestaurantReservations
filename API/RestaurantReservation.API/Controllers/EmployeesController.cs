using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using RestaurantReservation.API.DTOs;
using RestaurantReservation.API.ViewModels;
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
        private readonly IMapper _mapper;

        public EmployeesController(
            IEmployeeService employeeService, IMapper mapper,
            IValidator<PaginationInfo> paginationInfoValidator)
        {
            _employeeService = employeeService;
            _mapper = mapper;
            _paginationInfoValidator = paginationInfoValidator;
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<EmployeeVM>> GetEmployees(int id)
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
            var employeeVM = _mapper.Map<List<EmployeeVM>>(employees);

            var collectionVM = new CollectionVM<EmployeeVM>()
            {
                Count = employeeVM.Count,
                Items = employeeVM
            };

            Response.Headers.Add("X-Pagination",
              JsonSerializer.Serialize(paginationMetadata));
            return Ok(collectionVM);
        }
    }
}
