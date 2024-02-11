using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using RestaurantReservation.Application.Entities;
using RestaurantReservation.Application.Services.IServices;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace RestaurantReservation.Infrastructure.Security
{
    public class JwtTokenGenerator : IJwtTokenGenerator
    {
        private readonly string _issuer;
        private readonly string _audience;
        private readonly int _expiresMinutes;
        private readonly byte[] _key;
        public JwtTokenGenerator(IOptions<JwtSettings> jwtSettingsOptions)
        {
            var jwtSettings = jwtSettingsOptions.Value;
            _issuer = jwtSettings.Issuer;
            _audience = jwtSettings.Audience;
            _expiresMinutes = jwtSettings.ExpiresMinutes;
            _key = Encoding.ASCII.GetBytes(jwtSettings.Key);
        }

        public string GenerateToken(User user)
        {
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                new Claim(JwtRegisteredClaimNames.Name, user.Name!),
            }),
                Expires = DateTime.UtcNow.AddMinutes(_expiresMinutes),
                Issuer = _issuer,
                Audience = _audience,
                SigningCredentials = new SigningCredentials
                (new SymmetricSecurityKey(_key),
                SecurityAlgorithms.HmacSha256)
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var stringToken = tokenHandler.WriteToken(token);

            return stringToken;
        }
    }
}
