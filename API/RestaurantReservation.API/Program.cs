using Microsoft.OpenApi.Models;
using RestaurantReservation.API.Extensions;
using RestaurantReservation.API.Middleware;
using RestaurantReservation.Application.Extensions;
using RestaurantReservation.Persistence.Extensions;
using RestaurantReservations.Infrastructure.Extensions;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddPersistenceServices(builder.Configuration);
builder.Services.AddApplicationServices();

builder.Services.AddValidators();

builder.Services.AddControllers();
builder.Services.AddAPIVersioning(builder.Configuration);
builder.Services.AddInfrastructureServices(builder.Configuration);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGeneration();


var app = builder.Build();
app.UseMiddleware<ExceptionHandlerMiddleware>();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
