using AutoMapper;
using RestaurantReservation.Domain.Entities;
using RestaurantReservation.Domain.Models;
using RestaurantReservation.Domain.Repositories.IRepositories;
using RestaurantReservation.Domain.Services.IServices;
using FluentResults;

namespace RestaurantReservation.Domain.Services
{
    public class CustomerService : EntityService<Customer, CustomerDTO, ICustomerRepository>, ICustomerService
    {
        public CustomerService(ICustomerRepository entityRepository, IMapper mapper) : base(entityRepository, mapper)
        {
        }

        public async Task<(IEnumerable<CustomerDTO>?, Result)> FindCustomersByPartySizeAsync(int partySize)
        {
            try
            {
                var customers = await _entityRepository.FindCustomersByPartySizeAsync(partySize);
                var dtos = MapEntityToDto(customers);
                return (dtos, Result.Ok());
            }
            catch (Exception ex)
            {
                return (null, Result.Fail(ex.Message));
            }
        }
    }
}
