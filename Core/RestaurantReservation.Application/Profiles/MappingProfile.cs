using AutoMapper;
using RestaurantReservation.Domain.Models;
using RestaurantReservation.Domain.Models.RestaurantReservation.Db.Entities;
using RestaurantReservation.Domain.Entities;

namespace RestaurantReservation.Domain.Mapper
{
    public class MappingProfile : Profile
    {
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
            CreateMap<OrderWithMenuItemDTO, Order>();
            CreateMap<Order, OrderWithMenuItemDTO>();
            CreateMap<ReservationsDetails, ReservationsDetailsViewDTO>();
            CreateMap<ReservationsDetailsViewDTO, ReservationsDetails>();
            CreateMap<EmployeesWithRestaurantDetails, EmployeesWithRestaurantDetailsDTO>();
            CreateMap<EmployeesWithRestaurantDetailsDTO, EmployeesWithRestaurantDetails>();
        }
    }
}
