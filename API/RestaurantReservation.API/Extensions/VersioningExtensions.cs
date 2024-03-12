using Asp.Versioning;
using Microsoft.Extensions.Options;

namespace RestaurantReservation.API.Extensions
{
    public static class VersioningExtensions
    {
        public static IServiceCollection AddAPIVersioning(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<RestaurantReservation.Infrastructure.Options.ApiVersioningOptions>(
                configuration.GetSection("ApiVersioning"));

            services.AddApiVersioning(options =>
            {
                var apiVersioningOptions = services.BuildServiceProvider()
                .GetRequiredService<IOptions<RestaurantReservation.Infrastructure.Options.ApiVersioningOptions>>()
                .Value;

                options.DefaultApiVersion = new ApiVersion(apiVersioningOptions.DefaultApiVersion, 0);
                options.AssumeDefaultVersionWhenUnspecified = apiVersioningOptions.AssumeDefaultVersionWhenUnspecified;
                options.ReportApiVersions = apiVersioningOptions.ReportApiVersions;

                options.ApiVersionReader =
                  ApiVersionReader.Combine(
                    new HeaderApiVersionReader("Api-Version"),
                    new QueryStringApiVersionReader("version"));
            });

            return services;
        }
    }
}
