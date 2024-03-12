using RestaurantReservation.Domain.Constants;

namespace RestaurantReservation.API.DTOs
{
    /// <summary>
    /// Data transfer object for pagination information.
    /// </summary>
    public class PaginationInfo
    {
        /// <summary>
        /// The page number to retrieve.
        /// </summary>
        public int PageNumber { get; set; }

        /// <summary>
        /// The size of each page.
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaginationInfo"/> class with default values.
        /// </summary>
        public PaginationInfo()
        {
            PageNumber = PaginationConstants.DefaultPageNumber;
            PageSize = PaginationConstants.DefaultPageSize;
        }
    }
}
