using RestaurantReservation.Application.Contracts.IServices;
using RestaurantReservation.Application.Contracts.Persistence;
using RestaurantReservation.Application.DTOs;
using RestaurantReservation.Application.Exceptions;
using RestaurantReservation.Domain.Common;

namespace RestaurantReservation.Application.Services
{
    public class ReservationService : IReservationService
    {
        private readonly IReservationRepository _reservationRepository;
        private readonly ICustomerRepository _customerRepository;

        public ReservationService(
            IReservationRepository reservationRepository, ICustomerRepository customerRepository)
        {
            _reservationRepository = reservationRepository;
            _customerRepository = customerRepository;
        }

        public async Task<ReservationDTO?> CreateReservationAsync(ReservationDTO dto)
        {
            try
            {
                var reservation = await _reservationRepository.CreateAsync(dto);
                return reservation;
            }
            catch (Exception ex)
            {
                throw new InternalServerException("Error creating reservation", ex);
            }
        }

        public async Task DeleteReservationAsync(int id)
        {
            var reservation = await _reservationRepository.RetrieveByIdAsync(id);
            if (reservation == null)
            {
                throw new NotFoundException("Reservation not found");
            }

            await _reservationRepository.DeleteAsync(id);
        }

        public async Task<(IEnumerable<ReservationDTO>, PaginationMetadata)> RetrieveReservationAsync(
            int pageNumber, int pageSize)
        {
            try
            {
                var reservations = await _reservationRepository.RetrieveAllAsync(pageNumber, pageSize);
                return reservations;
            }
            catch (Exception ex)
            {
                throw new InternalServerException("Error retrieving reservations", ex);
            }
        }

        public async Task<ReservationDTO?> RetrieveReservationByIdAsync(int id)
        {
            try
            {
                var reservation = await _reservationRepository.RetrieveByIdAsync(id);
                if (reservation == null)
                    throw new NotFoundException("Reservation not found");

                return reservation;
            }
            catch (NotFoundException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new InternalServerException("Error retrieving reservation", ex);
            }
        }

        public async Task UpdateReservationAsync(int id, ReservationDTO dto)
        {
            try
            {
                var reservation = await _reservationRepository.RetrieveByIdAsync(id);
                if (reservation == null)
                    throw new NotFoundException("Reservation not found");

                dto.ReservationId = id;
                await _reservationRepository.UpdateAsync(dto);
            }
            catch (NotFoundException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new InternalServerException("Error updating reservation", ex);
            }
        }

        public async Task<IEnumerable<ReservationDTO>> GetReservationsByCustomerAsync(int customerId)
        {
            try
            {
                var customer = await _customerRepository.RetrieveByIdAsync(customerId);
                if (customer == null)
                    throw new NotFoundException("Customer not found");

                var reservations = await _reservationRepository.GetReservationsByCustomerAsync(customerId);
                return reservations;
            }
            catch (NotFoundException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new InternalServerException("Error retrieving reservations by customer", ex);
            }
        }

        public async Task<IEnumerable<ReservationsDetailsDTO>> GetReservationsDetailsAsync()
        {
            try
            {
                var reservationsDetails = await _reservationRepository.RetrieveReservationsDetailsAsync();
                return reservationsDetails;
            }
            catch (Exception ex)
            {
                throw new InternalServerException("Error listing reservations details", ex);
            }
        }
    }
}
