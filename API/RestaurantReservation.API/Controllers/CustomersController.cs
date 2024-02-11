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
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        private readonly IValidator<CustomerRequestDTO> _customerRequestValidator;
        private readonly IValidator<PaginationInfo> _paginationInfoValidator;
        private readonly IMapper _mapper;
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

        [HttpGet("{id:int}")]
        public async Task<ActionResult<CustomerVM>> GetCustomer(int id)
        {
            var customer = await _customerService.RetrieveCustomerByIdAsync(id);
            return Ok(_mapper.Map<CustomerVM>(customer));
        }

        [HttpGet]
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

        [HttpPost]
        public async Task<ActionResult<CustomerVM>> CreateCustomer(CustomerRequestDTO customerRequestDTO)
        {
            await _customerRequestValidator.ValidateAndThrowAsync(customerRequestDTO);

            var customer = await _customerService.CreateCustomerAsync(_mapper.Map<CustomerDTO>(customerRequestDTO));
            return CreatedAtAction(
            nameof(GetCustomer),
            new { id = customer!.CustomerId },
                _mapper.Map<CustomerVM>(customer));
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> UpdateCustomer(
            int id, CustomerRequestDTO customerRequestDTO)
        {
            await _customerRequestValidator.ValidateAndThrowAsync(customerRequestDTO);
            await _customerService.UpdateCustomerAsync(id, _mapper.Map<CustomerDTO>(customerRequestDTO));

            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeleteCustomer(
         int id)
        {
            await _customerService.DeleteCustomerAsync(id);

            return NoContent();
        }
    }
}
