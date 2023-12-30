using AutoMapper;
using RestaurantReservation.Db.DTOs;
using RestaurantReservation.Db.Entities;

namespace RestaurantReservation.Db.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer, CustomerDTO>();
            CreateMap<CustomerDTO, Customer>();
            CreateMap<Employee, EmployeeDTO>();
        }
    }
}
