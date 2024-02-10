using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Infrastructure;
using RestaurantReservation.API.Exceptions;
using RestaurantReservation.Application.Exceptions;
using System.Text.Json;

namespace RestaurantReservation.API.Middleware
{
    public class ExceptionHandlerMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly Dictionary<Type, IExceptionHandler> _exceptionHandlers;

        public ExceptionHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
            _exceptionHandlers = new Dictionary<Type, IExceptionHandler>
        {
            { typeof(NotFoundException), new NotFoundExceptionHandler() },
            { typeof(InternalServerException), new InternalServerErrorExceptionHandler() },
            { typeof(FluentValidation.ValidationException), new ValidationExceptionHandler() }

        };
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                var exceptionType = ex.GetType();
                if (_exceptionHandlers.TryGetValue(exceptionType, out var handler))
                {
                    await handler.HandleAsync(context, ex);
                }
                else
                {
                    await HandleUnknownExceptionAsync(context, ex);
                }
            }
        }
        private async Task HandleUnknownExceptionAsync(HttpContext context, Exception ex)
        {
            var problemDetails = new ProblemDetails
            {
                Status = StatusCodes.Status500InternalServerError,
                Title = "An error occurred",
                Detail = ex.Message
            };

            context.Response.StatusCode = StatusCodes.Status500InternalServerError;
            context.Response.ContentType = "application/json";

            await context.Response.WriteAsync(JsonSerializer.Serialize(problemDetails));
        }
    }
}
