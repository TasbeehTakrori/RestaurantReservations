using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using RestaurantReservation.API.DTOs;
using RestaurantReservation.API.ViewModels;
using RestaurantReservation.Application.DTOs;
using RestaurantReservation.Application.Services;
using RestaurantReservation.Application.Services.IServices;
using System.Text.Json;

namespace RestaurantReservation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationsController : ControllerBase
    {
        private readonly IReservationService _reservationService;
        private readonly IOrderService _orderService;
        private readonly IValidator<ReservationRequestDTO> _reservationRequestValidator;
        private readonly IValidator<PaginationInfo> _paginationInfoValidator;
        private readonly IMapper _mapper;

        public ReservationsController(
            IReservationService reservationService,
            IMapper mapper,
            IValidator<ReservationRequestDTO> reservationRequestValidator,
            IValidator<PaginationInfo> paginationInfoValidator,
            IOrderService orderService)
        {
            _reservationService = reservationService;
            _mapper = mapper;
            _reservationRequestValidator = reservationRequestValidator;
            _paginationInfoValidator = paginationInfoValidator;
            _orderService = orderService;
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<ReservationVM>> GetReservation(int id)
        {
            var reservation = await _reservationService.RetrieveReservationByIdAsync(id);
            return Ok(_mapper.Map<ReservationVM>(reservation));
        }

        [HttpGet]
        public async Task<ActionResult<CollectionVM<ReservationVM>>> GetReservations(
            [FromQuery] PaginationInfo paginationInfo)
        {
            await _paginationInfoValidator.ValidateAndThrowAsync(paginationInfo);

            (var reservations, var paginationMetadata) = await _reservationService.RetrieveReservationAsync(
                paginationInfo.PageNumber, paginationInfo.PageSize);
            var reservationVMs = _mapper.Map<List<ReservationVM>>(reservations);

            var collectionVM = new CollectionVM<ReservationVM>()
            {
                Count = reservationVMs.Count,
                Items = reservationVMs
            };

            Response.Headers.Add("X-Pagination",
              JsonSerializer.Serialize(paginationMetadata));
            return Ok(collectionVM);
        }

        [HttpPost]
        public async Task<ActionResult<ReservationVM>> CreateReservation(ReservationRequestDTO reservationRequestDTO)
        {
            await _reservationRequestValidator.ValidateAndThrowAsync(reservationRequestDTO);

            var reservation = await _reservationService.CreateReservationAsync(_mapper.Map<ReservationDTO>(reservationRequestDTO));
            return CreatedAtAction(
            nameof(GetReservation),
            new { id = reservation!.ReservationId },
                _mapper.Map<ReservationVM>(reservation));
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> UpdateReservation(
            int id, ReservationRequestDTO reservationRequestDTO)
        {
            await _reservationRequestValidator.ValidateAndThrowAsync(reservationRequestDTO);
            await _reservationService.UpdateReservationAsync(id, _mapper.Map<ReservationDTO>(reservationRequestDTO));

            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeleteReservation(
         int id)
        {
            await _reservationService.DeleteReservationAsync(id);

            return NoContent();
        }

        [HttpGet("customer/{id:int}")]
        public async Task<ActionResult<CollectionVM<ReservationVM>>> GetReservationsByCustomerAsync(int id)
        {
            var reservations = await _reservationService.GetReservationsByCustomerAsync(id);
            var reservationsVm = _mapper.Map<List<ReservationVM>>(reservations);

            var collectionVM = new CollectionVM<ReservationVM>()
            {
                Count = reservationsVm.Count,
                Items = reservationsVm
            };
            return Ok(collectionVM);
        }

        [HttpGet("{id:int}/orders")]
        public async Task<ActionResult<CollectionVM<ReservationVM>>> GetOrdersWithMenuItemsAsync(int id)
        {
            var ordersWithMenuItems = await _orderService.GetOrdersAndMenuItemsAsync(id);
            var ordersWithMenuItemsVm = _mapper.Map<List<OrderWithMenuItemsVM>>(ordersWithMenuItems);

            var collectionVM = new CollectionVM<OrderWithMenuItemsVM>()
            {
                Count = ordersWithMenuItemsVm.Count,
                Items = ordersWithMenuItemsVm
            };
            return Ok(collectionVM);
        }
    }
}
