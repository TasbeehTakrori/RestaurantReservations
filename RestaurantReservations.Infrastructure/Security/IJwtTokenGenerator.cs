using RestaurantReservation.Application.Entities;

namespace RestaurantReservation.Application.Services.IServices
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(User user);
    }
}