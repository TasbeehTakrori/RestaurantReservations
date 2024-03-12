using AutoMapper;
using RestaurantReservation.API.DTOs;
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
            CreateMap<EmployeeRequestDTO, EmployeeDTO>()
             .ReverseMap();
        }
    }
}
