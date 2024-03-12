using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using RestaurantReservation.API.DTOs;
using RestaurantReservation.API.ViewModels;
using RestaurantReservation.Application.Contracts.IServices;
using RestaurantReservation.Application.DTOs;
using System.Text.Json;

namespace RestaurantReservation.API.Controllers
{
    /// <summary>
    /// API Controller for managing reservations.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationsController : ControllerBase
    {
        private readonly IReservationService _reservationService;
        private readonly IOrderService _orderService;
        private readonly IValidator<ReservationRequestDTO> _reservationRequestValidator;
        private readonly IValidator<PaginationInfo> _paginationInfoValidator;
        private readonly IMapper _mapper;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReservationsController"/> class.
        /// </summary>
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

        /// <summary>
        /// Retrieves a reservation by its ID.
        /// </summary>
        /// <param name="id">The ID of the reservation to retrieve.</param>
        /// <returns>The retrieved reservation.</returns>
        [HttpGet("{id:int}")]
        public async Task<ActionResult<ReservationVM>> GetReservation(int id)
        {
            var reservation = await _reservationService.RetrieveReservationByIdAsync(id);
            return Ok(_mapper.Map<ReservationVM>(reservation));
        }

        /// <summary>
        /// Retrieves a list of reservations with pagination.
        /// </summary>
        /// <param name="paginationInfo">Pagination information.</param>
        /// <returns>A list of reservations with pagination metadata.</returns>
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

        /// <summary>
        /// Creates a new reservation.
        /// </summary>
        /// <param name="reservationRequestDTO">The reservation data to create.</param>
        /// <returns>The created reservation.</returns>
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
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

        /// <summary>
        /// Updates an existing reservation.
        /// </summary>
        /// <param name="id">The ID of the reservation to update.</param>
        /// <param name="reservationRequestDTO">The updated reservation data.</param>
        /// <returns>No content if successful.</returns>
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPut("{id:int}")]
        public async Task<ActionResult> UpdateReservation(
            int id, ReservationRequestDTO reservationRequestDTO)
        {
            await _reservationRequestValidator.ValidateAndThrowAsync(reservationRequestDTO);
            await _reservationService.UpdateReservationAsync(id, _mapper.Map<ReservationDTO>(reservationRequestDTO));

            return NoContent();
        }

        /// <summary>
        /// Deletes a reservation by its ID.
        /// </summary>
        /// <param name="id">The ID of the reservation to delete.</param>
        /// <returns>No content if successful.</returns>
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeleteReservation(
         int id)
        {
            await _reservationService.DeleteReservationAsync(id);

            return NoContent();
        }

        /// <summary>
        /// Retrieves a list of reservations made by a specific customer.
        /// </summary>
        /// <param name="id">The ID of the customer.</param>
        /// <returns>A list of reservations made by the customer.</returns>
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

        /// <summary>
        /// Retrieves a list of orders along with menu items for a specific reservation.
        /// </summary>
        /// <param name="id">The ID of the reservation.</param>
        /// <returns>A list of orders along with menu items.</returns>
        [HttpGet("{id:int}/orders")]
        public async Task<ActionResult<CollectionVM<OrderWithMenuItemsVM>>> GetOrdersWithMenuItemsAsync(int id)
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

        /// <summary>
        /// Retrieves a list of menu items ordered in a specific reservation.
        /// </summary>
        /// <param name="id">The ID of the reservation.</param>
        /// <returns>A list of menu items ordered in the reservation.</returns>
        [HttpGet("{id:int}/menuItems")]
        public async Task<ActionResult<CollectionVM<MenuItemVM>>> GetOrderedMenuItemsAsync(int id)
        {
            var orderedMenuItems = await _orderService.GetOrderedMenuItemsAsync(id);
            var orderedMenuItemsVm = _mapper.Map<List<MenuItemVM>>(orderedMenuItems);

            var collectionVM = new CollectionVM<MenuItemVM>()
            {
                Count = orderedMenuItemsVm.Count,
                Items = orderedMenuItemsVm
            };
            return Ok(collectionVM);
        }
    }
}
