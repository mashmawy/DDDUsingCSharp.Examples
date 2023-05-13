namespace OrderExample.Services
{
    public interface IOrderQueriesService
    {
        Task<OrderDto> GetOrderById(int orderId);
        Task<IEnumerable<OrderItemDto>> GetOrdersItemsList(int orderId);
        Task<IEnumerable<OrderDto>> GetOrdersList();
    }
}
