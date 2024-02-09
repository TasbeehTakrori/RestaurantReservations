using Microsoft.AspNetCore.Mvc;
using RestaurantReservation.Application.Exceptions;
using System.Text.Json;

namespace RestaurantReservation.API.Middleware
{
    public class ExceptionHandlerMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (NotFoundException ex)
            {
                await HandleExceptionAsync(context, ex, StatusCodes.Status404NotFound, "Resource not found");
            }
            catch (InternalServerException ex)
            {
                await HandleExceptionAsync(context, ex, StatusCodes.Status500InternalServerError, "Internal server error");
            }
            catch (FluentValidation.ValidationException ex)
            {
                await HandleExceptionAsync(context, ex, StatusCodes.Status400BadRequest, "Validation error");
            }
        }

        private async Task HandleExceptionAsync(HttpContext context, Exception ex, int statusCode, string title)
        {
            var problemDetails = new ProblemDetails
            {
                Status = statusCode,
                Title = title,
                Detail = ex.Message
            };

            context.Response.StatusCode = statusCode;
            context.Response.ContentType = "application/json";

            await context.Response.WriteAsync(JsonSerializer.Serialize(problemDetails));
        }
    }
}
