using RestaurantReservation.Domain.Constants;

namespace RestaurantReservation.API.DTOs
{
    public class PaginationInfo
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }

        public PaginationInfo()
        {
            PageNumber = PaginationConstants.DefaultPageNumber;
            PageSize = PaginationConstants.DefaultPageSize;
        }
    }
}
