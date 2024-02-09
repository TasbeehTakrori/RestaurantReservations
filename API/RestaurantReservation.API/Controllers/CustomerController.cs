using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RestaurantReservation.Application.Services.IServices;

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

        [HttpGet]
        public async Task<IEnumerable<CustomerVm>> GetCustomers(int pageNumber = 1, int pageSize = 5)
        {
            var customers = _customerService.RetrieveCustomersAsync(pageNumber, pageSize);
            return _mapper.Map<IEnumerable<CustomerVm>>(customers);
        }
    }
}
