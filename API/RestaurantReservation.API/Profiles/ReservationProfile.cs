using AutoMapper;
using RestaurantReservation.API.DTOs;
using RestaurantReservation.API.ViewModels;
using RestaurantReservation.Application.DTOs;

namespace RestaurantReservation.API.Profiles
{
    public class ReservationProfile : Profile
    {
        public ReservationProfile()
        {
            CreateMap<ReservationRequestDTO, ReservationDTO>()
                .ReverseMap();
            CreateMap<ReservationDTO, ReservationVM>()
             .ReverseMap();
        }
    }
}
