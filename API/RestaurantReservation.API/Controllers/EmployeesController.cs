using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using RestaurantReservation.API.DTOs;
using RestaurantReservation.API.ViewModels;
using RestaurantReservation.Application.Contracts.IServices;
using RestaurantReservation.Application.DTOs;
using RestaurantReservation.Application.Services.IServices;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;

namespace RestaurantReservation.API.Controllers
{
    /// <summary>
    /// Controller to handle operations related to employees.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        private readonly IValidator<PaginationInfo> _paginationInfoValidator;
        private readonly IValidator<EmployeeRequestDTO> _employeeRequestValidator;
        private readonly IOrderService _orderService;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor for EmployeesController.
        /// </summary>
        /// <param name="employeeService">Service for employee operations.</param>
        /// <param name="mapper">AutoMapper instance for object mapping.</param>
        /// <param name="paginationInfoValidator">Validator for pagination information.</param>
        /// <param name="employeeRequestValidator">Validator for employee requests.</param>
        /// <param name="orderService">Service for order operations.</param>
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

        /// <summary>
        /// Retrieve an employee by ID.
        /// </summary>
        /// <param name="id">ID of the employee to retrieve.</param>
        /// <returns>The requested employee.</returns>
        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<EmployeeVM>> GetEmployee(int id)
        {
            var employee = await _employeeService.RetrieveEmployeeByIdAsync(id);
            if (employee == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<EmployeeVM>(employee));
        }

        /// <summary>
        /// Retrieve employees with pagination.
        /// </summary>
        /// <param name="paginationInfo">Pagination information.</param>
        /// <param name="position">Optional filter by employee position.</param>
        /// <returns>A collection of employees.</returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<CollectionVM<EmployeeVM>>> GetEmployees(
            [FromQuery] PaginationInfo paginationInfo, string? position)
        {
            await _paginationInfoValidator.ValidateAndThrowAsync(paginationInfo);

            (var employees, var paginationMetadata) = await _employeeService.RetrieveEmployeesAsync(
                paginationInfo.PageNumber, paginationInfo.PageSize, position);
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

        /// <summary>
        /// Create a new employee.
        /// </summary>
        /// <param name="employeeRequestDTO">Data for creating the employee.</param>
        /// <returns>The created employee.</returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<EmployeeVM>> CreateEmployee([FromBody] EmployeeRequestDTO employeeRequestDTO)
        {
            await _employeeRequestValidator.ValidateAndThrowAsync(employeeRequestDTO);

            var employee = await _employeeService.CreateEmployeeAsync(_mapper.Map<EmployeeDTO>(employeeRequestDTO));
            return CreatedAtAction(
                nameof(GetEmployee),
                new { id = employee!.EmployeeId },
                _mapper.Map<EmployeeVM>(employee));
        }

        /// <summary>
        /// Update an existing employee.
        /// </summary>
        /// <param name="id">ID of the employee to update.</param>
        /// <param name="employeeRequestDTO">Data for updating the employee.</param>
        /// <returns>No content if successful.</returns>
        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> UpdateEmployee(
            int id, EmployeeRequestDTO employeeRequestDTO)
        {
            await _employeeRequestValidator.ValidateAndThrowAsync(employeeRequestDTO);
            var existingEmployee = await _employeeService.RetrieveEmployeeByIdAsync(id);
            if (existingEmployee == null)
            {
                return NotFound();
            }
            await _employeeService.UpdateEmployeeAsync(id, _mapper.Map<EmployeeDTO>(employeeRequestDTO));
            return NoContent();
        }

        /// <summary>
        /// Delete an employee by ID.
        /// </summary>
        /// <param name="id">ID of the employee to delete.</param>
        /// <returns>No content if successful.</returns>
        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> DeleteEmployee(int id)
        {
            var existingEmployee = await _employeeService.RetrieveEmployeeByIdAsync(id);
            if (existingEmployee == null)
            {
                return NotFound();
            }
            await _employeeService.DeleteEmployeeAsync(id);
            return NoContent();
        }

        /// <summary>
        /// Retrieve the average order amount for an employee.
        /// </summary>
        /// <param name="id">ID of the employee.</param>
        /// <returns>The average order amount.</returns>
        [HttpGet("{id:int}/averageOrderAmount")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<decimal>> GetEmployeeAverageOrderAmountAsync(int id)
        {
            var averageOrderAmount = await _orderService.CalculateAverageOrderAmountAsync(id);
            if (averageOrderAmount == null)
            {
                return NotFound();
            }
            return Ok(new { AverageOrderAmount = averageOrderAmount });
        }
    }
}
