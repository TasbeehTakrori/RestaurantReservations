namespace RestaurantReservations.Infrastructure.Options
{
    public class ApiVersioningOptions
    {
        public int DefaultApiVersion { get; set; }
        public bool AssumeDefaultVersionWhenUnspecified { get; set; }
        public bool ReportApiVersions { get; set; }
    }
}
