using AutoMapper;
using FluentResults;
using RestaurantReservation.Db.DTOs;
using RestaurantReservation.Db.Entities;
using RestaurantReservation.Db.Repositories.IRepositories;
using RestaurantReservation.Db.Services.IServices;

namespace RestaurantReservation.Db.Services
{
    public class ReservationService : EntityService<Reservation, ReservationDTO, IReservationRepository>, IReservationService
    {
        public ReservationService(IReservationRepository entityRepository, IMapper mapper) : base(entityRepository, mapper)
        {
        }
        public async Task<(IEnumerable<ReservationDTO>?, Result)> GetReservationsByCustomerAsync(int customerId)
        {
            try
            {
                var reservations = await _entityRepository.GetReservationsByCustomerAsync(customerId);
                var dto = MapEntityToDto(reservations);
                return (dto, Result.Ok());
            }
            catch (Exception ex)
            {
                return (null, Result.Fail(ex.Message));
            }
        }

        public async Task<(IEnumerable<ReservationsDetailsViewDTO>?, Result)> ListReservationsDetailsViewAsync()
        {
            try
            {
                var reservationsDetails = await _entityRepository.RetrieveReservationsDetailsViewAsync();
                var dto = MapEntityToDto<ReservationsDetailsView, ReservationsDetailsViewDTO>(reservationsDetails);
                return (dto, Result.Ok());
            }
            catch (Exception ex)
            {
                return (null, Result.Fail(ex.Message));
            }
        }
    }
}
