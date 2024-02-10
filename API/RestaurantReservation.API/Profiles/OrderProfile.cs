using AutoMapper;
using RestaurantReservation.API.ViewModels;
using RestaurantReservation.Application.DTOs;

namespace RestaurantReservation.API.Profiles
{
    public class OrderProfile : Profile
    {
        public OrderProfile()
        {
            CreateMap<OrderWithMenuItemsVM, OrderWithMenuItemsDTO>()
                .ReverseMap();
        }

    }
}
