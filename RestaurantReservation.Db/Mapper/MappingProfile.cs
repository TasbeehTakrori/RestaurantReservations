using AutoMapper;
using RestaurantReservation.Db.DTOs;
using RestaurantReservation.Db.DTOs.RestaurantReservation.Db.Entities;
using RestaurantReservation.Db.Entities;
using RestaurantReservation.Db.Entities.RestaurantReservation.Db.Entities;

namespace RestaurantReservation.Db.Mapper
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
            CreateMap<ReservationsDetailsView, ReservationsDetailsViewDTO>();
            CreateMap<ReservationsDetailsViewDTO, ReservationsDetailsView>();
            CreateMap<EmployeesWithRestaurantDetailsView, EmployeesWithRestaurantDetailsViewDTO>();
            CreateMap<EmployeesWithRestaurantDetailsViewDTO, EmployeesWithRestaurantDetailsView>();
        }
    }
}
