using AutoMapper;
using RestaurantReservation.Application.Entities;
using RestaurantReservation.Application.DTOs;

namespace RestaurantReservation.Persistence.Profiles
{
    public class MappingProfile : Profile
    {
        //TODO => Split to many profiles and use ReverseMap()
        public MappingProfile()
        {
            CreateMap<Customer, CustomerDTO>()
                .ReverseMap();

            CreateMap<Employee, EmployeeDTO>();
            CreateMap<EmployeeDTO, Employee>();
            CreateMap<MenuItemDTO, MenuItem>();
            CreateMap<MenuItem, MenuItemDTO>();
            CreateMap<Order, OrderDTO>();
            CreateMap<OrderDTO, Order>();
            CreateMap<OrderItem, OrderItemDTO>();
            CreateMap<OrderItemDTO, OrderItem>();
            CreateMap<Reservation, ReservationDTO>();
            CreateMap<ReservationDTO, Reservation>();
            CreateMap<Restaurant, RestaurantDTO>();
            CreateMap<RestaurantDTO, Restaurant>();
            CreateMap<Table, TableDTO>();
            CreateMap<TableDTO, Table>();
            CreateMap<OrderWithMenuItemDTO, Order>();
            CreateMap<Order, OrderWithMenuItemDTO>();
            CreateMap<ReservationsDetails, ReservationsDetailsViewDTO>();
            CreateMap<ReservationsDetailsViewDTO, ReservationsDetails>();
            CreateMap<EmployeesWithRestaurantDetails, EmployeesWithRestaurantDetailsDTO>();
            CreateMap<EmployeesWithRestaurantDetailsDTO, EmployeesWithRestaurantDetails>();
        }
    }
}
