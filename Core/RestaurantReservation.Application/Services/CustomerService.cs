using RestaurantReservation.Application.Models;
using RestaurantReservation.Application.Contracts.Persistence;
using RestaurantReservation.Application.Services.IServices;
using RestaurantReservation.Application.Exceptions;

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
                throw new ServiceException("Error creating customer", ex);
            }
        }

        public async Task DeleteCustomerAsync(int entityId)
        {
            var customer = await _customerRepository.RetrieveByIdAsync(entityId);
            if (customer == null)
            {
                throw new KeyNotFoundException("Customer not found");
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
                throw new ServiceException("Error finding customers by party size", ex);
            }
        }

        public async Task<CustomerDTO?> RetrieveCustomerByIdAsync(int id)
        {
            try
            {
                var customer = await _customerRepository.RetrieveByIdAsync(id);
                if (customer == null)
                    throw new KeyNotFoundException("Customer not found");

                return customer;
            }
            catch (KeyNotFoundException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new ServiceException("Error retrieving customer", ex);
            }
        }

        public async Task<IEnumerable<CustomerDTO>> RetrieveCustomersAsync(int pageNumber, int pageSize)
        {
            try
            {
                var customers = await _customerRepository.RetrieveAllAsync(pageNumber, pageSize);
                return customers;
            }
            catch (Exception ex)
            {
                throw new ServiceException("Error retrieving customers", ex);
            }
        }

        public async Task<CustomerDTO?> UpdateCustomerAsync(CustomerDTO dto)
        {
            try
            {
                var existingCustomer = await _customerRepository.RetrieveByIdAsync(dto.CustomerId);
                if (existingCustomer == null)
                    throw new KeyNotFoundException("Customer not found");

                var updatedCustomer = await _customerRepository.UpdateAsync(dto);
                return updatedCustomer;
            }
            catch (KeyNotFoundException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new ServiceException("Error updating customer", ex);
            }
        }
    }
}
