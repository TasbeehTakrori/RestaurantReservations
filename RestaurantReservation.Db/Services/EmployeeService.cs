using AutoMapper;
using FluentResults;
using RestaurantReservation.Db.DTOs;
using RestaurantReservation.Db.DTOs.RestaurantReservation.Db.Entities;
using RestaurantReservation.Db.Entities;
using RestaurantReservation.Db.Entities.RestaurantReservation.Db.Entities;
using RestaurantReservation.Db.Repositories.IRepositories;

namespace RestaurantReservation.Db.Services
{
    public class EmployeeService : EntityService<Employee, EmployeeDTO, IEmployeeRepository>
    {
        public EmployeeService(IEmployeeRepository employeeRepository, IMapper mapper) : base(employeeRepository, mapper)
        {
        }

        public async Task<(IEnumerable<EmployeeDTO>?, Result)> ListManagersAsync()
        {
            try
            {
                var employees = await _entityRepository.ListManagersAsync();
                var dtos = MapEntityToDto(employees);
                return (dtos, Result.Ok());
            }
            catch (Exception ex)
            {
                return (null, Result.Fail(ex.Message));
            }
        }
        
        public async Task<(IEnumerable<EmployeesWithRestaurantDetailsViewDTO>?, Result)> ListEmployeesWithRestaurantDetailsViewAsync()
        {
            try
            {
                var employees = await _entityRepository.ListEmployeesWithRestaurantDetailsViewAsync();
                var dtos = MapEntityToDto<EmployeesWithRestaurantDetailsView, EmployeesWithRestaurantDetailsViewDTO>(employees);
                return (dtos, Result.Ok());
            }
            catch (Exception ex)
            {
                return (null, Result.Fail(ex.Message));
            }
        }
    }
}
