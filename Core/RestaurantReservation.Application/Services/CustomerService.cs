using AutoMapper;
using FluentResults;
using RestaurantReservation.Domain.Models;
using RestaurantReservation.Domain.Entities;
using RestaurantReservation.Domain.Enums;
using RestaurantReservation.Domain.Repositories.IRepositories;
using RestaurantReservation.Domain.Services.IServices;

namespace RestaurantReservation.Domain.Services
{
    public class CustomerService : EntityService<Customer, CustomerDTO, ICustomerRepository>, ICustomerService
    {
        public CustomerService(ICustomerRepository entityRepository, IMapper mapper) : base(entityRepository, mapper)
        {
        }

        public async Task<(IEnumerable<CustomerDTO>?, Result)> FindCustomersByPartySizeAsync(PartySize partySize)
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
