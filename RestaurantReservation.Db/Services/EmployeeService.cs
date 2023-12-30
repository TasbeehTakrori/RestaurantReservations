using AutoMapper;
using FluentResults;
using RestaurantReservation.Db.DTOs;
using RestaurantReservation.Db.Entities;
using RestaurantReservation.Db.Repositories;

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


    }
}
