using AutoMapper;
using FluentResults;
using RestaurantReservation.Db.DTOs;
using RestaurantReservation.Db.Entities;
using RestaurantReservation.Db.Enums;
using RestaurantReservation.Db.Repositories.IRepositories;
using RestaurantReservation.Db.Services.IServices;

namespace RestaurantReservation.Db.Services
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
