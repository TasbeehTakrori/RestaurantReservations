using RestaurantReservation.Application.Contracts.Persistence;
using RestaurantReservation.Application.Exceptions;
using RestaurantReservation.Application.DTOs;
using RestaurantReservation.Application.Services.IServices;
using RestaurantReservation.Domain.Common;
using RestaurantReservation.Domain.Enums;

namespace RestaurantReservation.Application.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<IEnumerable<EmployeesWithRestaurantDetailsDTO>> GetEmployeesWithRestaurantDetailsAsync()
        {
            try
            {
                var employees = await _employeeRepository.ListEmployeesWithRestaurantDetailsAsync();
                return employees;
            }
            catch (Exception ex)
            {
                throw new InternalServerException("Error creating employee", ex);
            }
        }

        public async Task<EmployeeDTO?> CreateEmployeeAsync(EmployeeDTO dto)
        {
            try
            {
                var employee = await _employeeRepository.CreateAsync(dto);
                return employee;
            }
            catch (Exception ex)
            {
                throw new InternalServerException("Error creating employee", ex);
            }
        }

        public async Task DeleteEmployeeAsync(int id)
        {
            var employee = await _employeeRepository.RetrieveByIdAsync(id);
            if (employee == null)
            {
                throw new NotFoundException("Employee not found");
            }

            await _employeeRepository.DeleteAsync(id);
        }

        public async Task<(IEnumerable<EmployeeDTO>, PaginationMetadata)> RetrieveEmployeesAsync(
            int pageNumber, int pageSize, string? position)
        {
            IEnumerable<EmployeeDTO> employees;
            PaginationMetadata paginationMetadata;
            try
            {
                if (position == null)
                    (employees, paginationMetadata) = await _employeeRepository.RetrieveAllAsync(
                        pageNumber, pageSize);
                else
                {
                    Enum.TryParse<EmployeePosition>(position, out var employeePosition);
                    (employees, paginationMetadata) = await _employeeRepository.RetrieveAllAsync(
                   pageNumber, pageSize, employeePosition);
                }
                return (employees, paginationMetadata);
            }
            catch (Exception ex)
            {
                throw new InternalServerException("Error retrieving employees", ex);
            }
        }

        public async Task<EmployeeDTO?> RetrieveEmployeeByIdAsync(int id)
        {
            try
            {
                var employee = await _employeeRepository.RetrieveByIdAsync(id);
                if (employee == null)
                    throw new NotFoundException("Employee not found");

                return employee;
            }
            catch (NotFoundException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new InternalServerException("Error retrieving employee", ex);
            }
        }

        public async Task UpdateEmployeeAsync(int id, EmployeeDTO dto)
        {
            try
            {
                var employee = await _employeeRepository.RetrieveByIdAsync(id);
                if (employee == null)
                    throw new NotFoundException("Employee not found");

                dto.EmployeeId = id;
                await _employeeRepository.UpdateAsync(dto);
            }
            catch (NotFoundException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new InternalServerException("Error updating Employee", ex);
            }
        }
    }
}
