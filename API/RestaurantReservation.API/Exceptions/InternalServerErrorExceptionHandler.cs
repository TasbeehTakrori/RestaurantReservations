using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace RestaurantReservation.API.Exceptions
{
    public class InternalServerErrorExceptionHandler : IExceptionHandler
    {
        public async Task HandleAsync(HttpContext context, Exception ex)
        {
            var problemDetails = new ProblemDetails
            {
                Status = StatusCodes.Status500InternalServerError,
                Title = "Internal server error",
                Detail = ex.Message
            };

            context.Response.StatusCode = StatusCodes.Status500InternalServerError;
            context.Response.ContentType = "application/json";

            await context.Response.WriteAsync(JsonSerializer.Serialize(problemDetails));
        }
    }
}
