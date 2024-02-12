using RestaurantReservation.Application.DTOs;

namespace RestaurantReservation.Application.Contracts.IService
{
    public interface ILoginService
    {
        string? Login(LoginUserDTO loginUser);
    }
}