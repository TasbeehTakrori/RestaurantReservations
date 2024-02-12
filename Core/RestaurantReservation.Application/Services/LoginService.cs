using Microsoft.Extensions.Configuration;
using RestaurantReservation.Application.Contracts.IService;
using RestaurantReservation.Application.Contracts.IServices;
using RestaurantReservation.Application.DTOs;
using RestaurantReservation.Domain.Entities;

namespace RestaurantReservation.Application.Services
{
    public class LoginService : ILoginService
    {
        private readonly string _pepper;
        private readonly int _iteration = 3;
        private readonly IAuthenticationService _authenticationService;

        private readonly List<User> _userRepository = new List<User>()
        {
            new User {Name = "Tasbeeh", HashedPassword = "KQC76m3QBD2+E/SZ5tWLzxAb2eEaNUjFRmHvg9kicNo=", PasswordSalt="112255" },
            new User {Name = "Israa", HashedPassword = "123456", PasswordSalt="" },
            new User {Name = "Danya", HashedPassword = "123456", PasswordSalt = ""},
            new User {Name = "Ayah", HashedPassword = "123456", PasswordSalt = ""}
        };

        public LoginService(IAuthenticationService authenticationService)
        {
            _pepper = Environment.GetEnvironmentVariable("PasswordHashExamplePepper");
            _authenticationService = authenticationService;
        }
        public string? Login(LoginUserDTO loginUser)
        {
            var user = _userRepository
                .FirstOrDefault(u => u.Name == loginUser.Name);

            if (user == null)
                return null;

            var hashedPassword = PasswordHasher.ComputeHash(loginUser.Password, user.PasswordSalt, _pepper, _iteration);
            if (user.HashedPassword != hashedPassword)
                return null;

            var token = _authenticationService.GenerateJwtToken(loginUser);
            return token;
        }
    }
}
