using RestaurantReservation.Application.Contracts.IServices;
using RestaurantReservation.Domain.Entities;
using RestaurantReservation.Infrastructure.Authentication;

namespace RestaurantReservation.Application.Services
{
    internal class AuthenticationService : IAuthenticationService
    {
        private readonly IJwtTokenGenerator _jwtTokenGenerator;
        public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator)
        {
            _jwtTokenGenerator = jwtTokenGenerator;
        }

        public string GenerateJwtToken(User user)
        {
            return _jwtTokenGenerator.GenerateToken(user);
        }
    }
}
