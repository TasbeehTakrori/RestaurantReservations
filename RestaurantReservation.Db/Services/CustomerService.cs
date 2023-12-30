using AutoMapper;
using FluentResults;
using RestaurantReservation.Db.DTOs;
using RestaurantReservation.Db.Entities;
using RestaurantReservation.Db.Repositories.IRepositories;

namespace RestaurantReservation.Db.Services
{
    internal class CustomerService : EntityService<Customer, CustomerDTO, ICustomerRepository>
    {
        public CustomerService(ICustomerRepository entityRepository, IMapper mapper) : base(entityRepository, mapper)
        {
        }
    }
}
