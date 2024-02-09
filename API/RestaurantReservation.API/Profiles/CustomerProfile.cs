using AutoMapper;
using RestaurantReservation.API.Controllers;
using RestaurantReservation.Application.Models;

namespace RestaurantReservation.API.Profiles
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<CustomerVM, CustomerDTO>()
                .ReverseMap();
        }
    }
}
