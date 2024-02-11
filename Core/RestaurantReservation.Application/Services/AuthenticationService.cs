using RestaurantReservation.Application.Entities;
using RestaurantReservation.Application.Services.IServices;

namespace RestaurantReservation.Application.Services
{
    internal class AuthenticationService
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
