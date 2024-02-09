using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RestaurantReservation.API.ViewModels;
using RestaurantReservation.Application.Services.IServices;
using RestaurantReservation.Domain.Constants;
using System.Text.Json;

namespace RestaurantReservation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        private readonly IMapper _mapper;
        public CustomersController(ICustomerService customerService, IMapper mapper)
        {
            _customerService = customerService;
            _mapper = mapper;
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<CustomerVM>> GetCustomer(int id)
        {
            var customer = await _customerService.RetrieveCustomerByIdAsync(id);
            return Ok(_mapper.Map<CustomerVM>(customer));
        }

        [HttpGet]
        public async Task<ActionResult<CollectionVM<CustomerVM>>> GetCustomers(
             int pageNumber = PaginationConstants.DefaultPageNumber, int pageSize = PaginationConstants.DefaultPageSize)
        {
            (var customers, var paginationMetadata) = await _customerService.RetrieveCustomersAsync(pageNumber, pageSize);
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
    }
}
