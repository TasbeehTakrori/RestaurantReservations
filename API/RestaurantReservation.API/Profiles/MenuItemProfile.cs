using AutoMapper;
using RestaurantReservation.API.ViewModels;
using RestaurantReservation.Application.DTOs;

namespace RestaurantReservation.API.Profiles
{
    public class MenuItemProfile : Profile
    {
        public MenuItemProfile()
        {
            CreateMap<MenuItemMV, MenuItemDTO>()
                .ReverseMap();
        }
    }
}
