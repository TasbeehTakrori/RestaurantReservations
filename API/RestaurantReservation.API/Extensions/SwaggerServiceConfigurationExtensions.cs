using Microsoft.OpenApi.Models;
using System.Reflection;

namespace RestaurantReservation.API.Extensions
{
    public static class SwaggerServiceConfigurationExtensions
    {
        public static IServiceCollection AddSwaggerGeneration(this IServiceCollection services)
        {
            services.AddSwaggerGen(options =>
            {
                var xmlCommentsFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var filePath = Path.Combine(AppContext.BaseDirectory, xmlCommentsFile);
                options.IncludeXmlComments(filePath);

                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "RestaurantReservations API v1",
                    Description = "This is the documentation for version 1 of the RestaurantReservations API."
                });

                options.AddSecurityDefinition("RestaurantReservationApiBearerAuth", new OpenApiSecurityScheme()
                {
                    Type = SecuritySchemeType.Http,
                    Scheme = "Bearer",
                    Description = "Input a valid token to access this API"
                });

                options.AddSecurityRequirement(new OpenApiSecurityRequirement()
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "RestaurantReservationApiBearerAuth"
                            }
                        }, new List<string>()
                    }
                });
            });

            return services;
        }
    }
}
