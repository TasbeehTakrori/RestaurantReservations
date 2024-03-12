namespace RestaurantReservation.API.Exceptions
{
    public interface IExceptionHandler
    {
        Task HandleAsync(HttpContext context, Exception ex);
    }
}
