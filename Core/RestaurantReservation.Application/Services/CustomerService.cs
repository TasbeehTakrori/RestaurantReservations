using RestaurantReservation.Application.Contracts.Persistence;
using RestaurantReservation.Application.Exceptions;
using RestaurantReservation.Application.Models;
using RestaurantReservation.Application.Services.IServices;
using RestaurantReservation.Domain.Common;
using RestaurantReservation.Domain.Constants;
using System.ComponentModel.DataAnnotations;

namespace RestaurantReservation.Application.Services
{
    public class CustomerService : ICustomerService
    {
        protected readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<CustomerDTO?> CreateCustomerAsync(CustomerDTO dto)
        {
            try
            {
                var customer = await _customerRepository.CreateAsync(dto);
                return customer;
            }
            catch (Exception ex)
            {
                throw new InternalServerException("Error creating customer", ex);
            }
        }

        public async Task DeleteCustomerAsync(int entityId)
        {
            var customer = await _customerRepository.RetrieveByIdAsync(entityId);
            if (customer == null)
            {
                throw new NotFoundException("Customer not found");
            }

            await _customerRepository.DeleteAsync(entityId);
        }


        public async Task<IEnumerable<CustomerDTO>> FindCustomersByPartySizeAsync(
            int partySize, int pageNumber, int pageSize)
        {
            try
            {
                var customers = await _customerRepository.FindCustomersByPartySizeAsync(
                    partySize, pageNumber, pageSize);
                return customers;
            }
            catch (Exception ex)
            {
                throw new InternalServerException("Error finding customers by party size", ex);
            }
        }

        public async Task<CustomerDTO?> RetrieveCustomerByIdAsync(int id)
        {
            try
            {
                var customer = await _customerRepository.RetrieveByIdAsync(id);
                if (customer == null)
                    throw new NotFoundException("Customer not found");

                return customer;
            }
            catch (NotFoundException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new InternalServerException("Error retrieving customer", ex);
            }
        }

        public async Task<(IEnumerable<CustomerDTO>, PaginationMetadata)> RetrieveCustomersAsync(int pageNumber, int pageSize)
        {
            try
            {
                (var customers, var paginationMetadata) = await _customerRepository.RetrieveAllAsync(pageNumber, pageSize);
                return (customers, paginationMetadata);
            }
            catch (Exception ex)
            {
                throw new InternalServerException("Error retrieving customers", ex);
            }
        }

        public async Task<CustomerDTO?> UpdateCustomerAsync(int id, CustomerDTO dto)
        {
            try
            {
                var existingCustomer = await _customerRepository.RetrieveByIdAsync(id);
                if (existingCustomer == null)
                    throw new NotFoundException("Customer not found");

                dto.CustomerId = id;
                var updatedCustomer = await _customerRepository.UpdateAsync(dto);
                return updatedCustomer;
            }
            catch (NotFoundException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new InternalServerException("Error updating customer", ex);
            }
        }
    }
}
