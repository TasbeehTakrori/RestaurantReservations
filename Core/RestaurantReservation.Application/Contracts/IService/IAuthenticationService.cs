using RestaurantReservation.Application.DTOs;
using RestaurantReservation.Domain.Entities;

namespace RestaurantReservation.Application.Contracts.IServices
{
    public interface IAuthenticationService
    {
        string GenerateJwtToken(LoginUserDTO user);
    }
}