using EcommerceBackend.Business.src.Dtos.Order;
using EcommerceBackend.Domain.src.Common;

namespace EcommerceBackend.Business.src.Services.Abstractions
{
    public interface IOrderService
    {
        Task<IEnumerable<ReadOrderDto>> GetAllOrdersAsync(QueryOptions queryOptions);
        Task<ReadOrderDto> CreateOrderAsync(Guid userId, CreateOrderDto createOrderDto);
        // Task<ReadOrderDto> UpdateOrderAsync(Guid OrderId, UpdateOrderDto updateOrderDto);
        Task<ReadOrderDto> GetOrderByIdAsync(Guid OrderId);
        Task<bool> DeleteOrderByIdAsync(Guid orderId);
        Task<IEnumerable<ReadOrderDto>> GetOrdersByUserIdAsync(Guid userId);
    }
}