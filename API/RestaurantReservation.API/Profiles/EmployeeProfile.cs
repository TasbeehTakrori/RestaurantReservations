using AutoMapper;
using RestaurantReservation.API.ViewModels;
using RestaurantReservation.Application.DTOs;

namespace RestaurantReservation.API.Profiles
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<EmployeeVM, EmployeeDTO>()
                .ReverseMap();
        }
    }
}
