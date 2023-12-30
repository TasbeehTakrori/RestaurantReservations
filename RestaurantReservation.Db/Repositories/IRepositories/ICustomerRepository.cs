using FluentResults;
using RestaurantReservation.Db.DTOs;
using RestaurantReservation.Db.Entities;

namespace RestaurantReservation.Db.Repositories.IRepositories
{
    internal interface ICustomerRepository : IEntityRepository<Customer>
    {
    }
}
