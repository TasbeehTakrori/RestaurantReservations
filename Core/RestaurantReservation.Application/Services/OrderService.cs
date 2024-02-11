using RestaurantReservation.Application.Contracts.IServices;
using RestaurantReservation.Application.Contracts.Persistence;
using RestaurantReservation.Application.DTOs;
using RestaurantReservation.Application.Exceptions;
using RestaurantReservation.Domain.Common;

namespace RestaurantReservation.Application.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IReservationRepository _reservationRepository;
        public OrderService(
            IOrderRepository orderRepository,
            IReservationRepository reservationRepository,
            IEmployeeRepository employeeRepository)
        {
            _orderRepository = orderRepository;
            _reservationRepository = reservationRepository;
            _employeeRepository = employeeRepository;
        }
        public async Task<OrderDTO?> CreateOrderAsync(OrderDTO dto)
        {
            try
            {
                var order = await _orderRepository.CreateAsync(dto);
                return order;
            }
            catch (Exception ex)
            {
                throw new InternalServerException("Error creating order", ex);
            }
        }

        public async Task DeleteOrderAsync(int id)
        {
            var order = await _orderRepository.RetrieveByIdAsync(id);
            if (order == null)
            {
                throw new NotFoundException("Order not found");
            }

            await _orderRepository.DeleteAsync(id);
        }

        public async Task<(IEnumerable<OrderDTO>, PaginationMetadata)> RetrieveOrdersAsync(int pageNumber, int pageSize)
        {
            try
            {
                var orders = await _orderRepository.RetrieveAllAsync(pageNumber, pageSize);
                return orders;
            }
            catch (Exception ex)
            {
                throw new InternalServerException("Error retrieving orders", ex);
            }
        }

        public async Task<OrderDTO?> RetrieveOrderByIdAsync(int id)
        {
            try
            {
                var order = await _orderRepository.RetrieveByIdAsync(id);
                if (order == null)
                    throw new NotFoundException("Order not found");

                return order;
            }
            catch (NotFoundException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new InternalServerException("Error retrieving order", ex);
            }
        }

        public async Task UpdateOrderAsync(int id, OrderDTO dto)
        {
            try
            {
                var order = await _orderRepository.RetrieveByIdAsync(id);
                if (order == null)
                    throw new NotFoundException("Order not found");

                dto.OrderId = id;
                await _orderRepository.UpdateAsync(dto);
            }
            catch (NotFoundException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new InternalServerException("Error updating order", ex);
            }
        }
        public async Task<decimal> CalculateAverageOrderAmountAsync(int employeeId)
        {
            try
            {
                var employee = await _employeeRepository.RetrieveByIdAsync(employeeId);
                if (employee == null)
                    throw new NotFoundException("Employee not found");

                var avgOrderAmount = await _orderRepository.CalculateAverageOrderAmountAsync(employeeId);
                return avgOrderAmount;
            }
            catch (NotFoundException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new InternalServerException("Error Calculating AverageOrderAmount", ex);
            }
        }

        public async Task<IEnumerable<OrderWithMenuItemsDTO>> GetOrdersAndMenuItemsAsync(int reservationId)
        {
            try
            {
                var reservation = await _reservationRepository.RetrieveByIdAsync(reservationId);
                if (reservation == null)
                    throw new NotFoundException("Reservation not found");

                var ordersWithOrderItems = await _orderRepository.ListOrdersWithMenuItemsAsync(reservationId);

                return ordersWithOrderItems;
            }
            catch (NotFoundException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new InternalServerException("Error retrieving OrdersAndMenuItems", ex);
            }
        }

        public async Task<IEnumerable<MenuItemDTO>> GetOrderedMenuItemsAsync(int reservationId)
        {
            try
            {
                var reservation = await _reservationRepository.RetrieveByIdAsync(reservationId);
                if (reservation == null)
                    throw new NotFoundException("Reservation not found");

                var orderedMenuItems = await _orderRepository.ListOrderedMenuItemsAsync(reservationId);
                return orderedMenuItems;
            }
            catch (NotFoundException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new InternalServerException("Error retrieving OrdersAndMenuItems", ex);
            }
        }
    }
}
