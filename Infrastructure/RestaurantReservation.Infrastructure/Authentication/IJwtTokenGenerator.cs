namespace RestaurantReservation.Infrastructure.Authentication
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(string userName);
    }
}