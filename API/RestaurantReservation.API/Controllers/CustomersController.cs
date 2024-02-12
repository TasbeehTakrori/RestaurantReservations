using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RestaurantReservation.API.DTOs;
using RestaurantReservation.API.ViewModels;
using RestaurantReservation.Application.Contracts.IServices;
using RestaurantReservation.Application.DTOs;
using System.Text.Json;

namespace RestaurantReservation.API.Controllers
{
    /// <summary>
    /// Controller to handle operations related to customers.
    /// </summary>
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        private readonly IValidator<CustomerRequestDTO> _customerRequestValidator;
        private readonly IValidator<PaginationInfo> _paginationInfoValidator;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor for CustomersController.
        /// </summary>
        /// <param name="customerService">Service for customer operations.</param>
        /// <param name="mapper">AutoMapper instance for object mapping.</param>
        /// <param name="createCustomerValidator">Validator for customer creation requests.</param>
        /// <param name="paginationInfoValidator">Validator for pagination information.</param>
        public CustomersController(
            ICustomerService customerService,
            IMapper mapper,
            IValidator<CustomerRequestDTO> createCustomerValidator,
            IValidator<PaginationInfo> paginationInfoValidator)
        {
            _customerService = customerService;
            _mapper = mapper;
            _customerRequestValidator = createCustomerValidator;
            _paginationInfoValidator = paginationInfoValidator;
        }

        /// <summary>
        /// Retrieve a customer by ID.
        /// </summary>
        /// <param name="id">ID of the customer to retrieve.</param>
        /// <returns>The requested customer.</returns>
        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<CustomerVM>> GetCustomer(int id)
        {
            var customer = await _customerService.RetrieveCustomerByIdAsync(id);
            if (customer == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<CustomerVM>(customer));
        }

        /// <summary>
        /// Retrieve customers with pagination.
        /// </summary>
        /// <param name="paginationInfo">Pagination information.</param>
        /// <returns>A collection of customers.</returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<CollectionVM<CustomerVM>>> GetCustomers(
            [FromQuery] PaginationInfo paginationInfo)
        {
            await _paginationInfoValidator.ValidateAndThrowAsync(paginationInfo);

            (var customers, var paginationMetadata) = await _customerService.RetrieveCustomersAsync(paginationInfo.PageNumber, paginationInfo.PageSize);
            var customerVMs = _mapper.Map<List<CustomerVM>>(customers);

            var collectionVM = new CollectionVM<CustomerVM>()
            {
                Count = customerVMs.Count,
                Items = customerVMs
            };

            Response.Headers.Add("X-Pagination",
              JsonSerializer.Serialize(paginationMetadata));
            return Ok(collectionVM);
        }

        /// <summary>
        /// Create a new customer.
        /// </summary>
        /// <param name="customerRequestDTO">Data for creating the customer.</param>
        /// <returns>The created customer.</returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<CustomerVM>> CreateCustomer(CustomerRequestDTO customerRequestDTO)
        {
            await _customerRequestValidator.ValidateAndThrowAsync(customerRequestDTO);

            var customer = await _customerService.CreateCustomerAsync(_mapper.Map<CustomerDTO>(customerRequestDTO));
            return CreatedAtAction(
            nameof(GetCustomer),
            new { id = customer!.CustomerId },
                _mapper.Map<CustomerVM>(customer));
        }

        /// <summary>
        /// Update an existing customer.
        /// </summary>
        /// <param name="id">ID of the customer to update.</param>
        /// <param name="customerRequestDTO">Data for updating the customer.</param>
        /// <returns>No content if successful.</returns>
        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> UpdateCustomer(
            int id, CustomerRequestDTO customerRequestDTO)
        {
            await _customerRequestValidator.ValidateAndThrowAsync(customerRequestDTO);
            var existingCustomer = await _customerService.RetrieveCustomerByIdAsync(id);
            if (existingCustomer == null)
            {
                return NotFound();
            }
            await _customerService.UpdateCustomerAsync(id, _mapper.Map<CustomerDTO>(customerRequestDTO));
            return NoContent();
        }

        /// <summary>
        /// Delete a customer by ID.
        /// </summary>
        /// <param name="id">ID of the customer to delete.</param>
        /// <returns>No content if successful.</returns>
        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> DeleteCustomer(int id)
        {
            var existingCustomer = await _customerService.RetrieveCustomerByIdAsync(id);
            if (existingCustomer == null)
            {
                return NotFound();
            }
            await _customerService.DeleteCustomerAsync(id);
            return NoContent();
        }
    }
}
