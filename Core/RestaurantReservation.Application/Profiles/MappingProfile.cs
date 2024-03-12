using AutoMapper;
using RestaurantReservation.Application.Entities;
using RestaurantReservation.Application.DTOs;

namespace RestaurantReservation.Application.Mapper
{
    public class MappingProfile : Profile
    {
        //TODO => Split to many profiles and use ReverseMap()
        public MappingProfile()
        {
            CreateMap<Customer, CustomerDTO>();
            CreateMap<CustomerDTO, Customer>();
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
            CreateMap<OrderWithMenuItemsDTO, Order>();
            CreateMap<Order, OrderWithMenuItemsDTO>();
            CreateMap<ReservationsDetails, ReservationsDetailsDTO>();
            CreateMap<ReservationsDetailsDTO, ReservationsDetails>();
            CreateMap<EmployeesWithRestaurantDetails, EmployeesWithRestaurantDetailsDTO>();
            CreateMap<EmployeesWithRestaurantDetailsDTO, EmployeesWithRestaurantDetails>();
        }
    }
}
