namespace OrderExample.Services
{
    public interface IOrdersCommandsService
    {
        Task AddOrderItemAsync(OrderItemDto orderItemDto);
        Task CreateOrderAsync(OrderDto orderDto);
        Task DeleteOrderByIdAsync(int id);
        Task FixItemDescriptionAsync(int orderId, int orderItemId, string fixedItemDescription);
        Task UpdateOrderShippingAddressAsync(ShippingAddressDto shippingAddressDto);
        Task UpdatePriceAsync(int orderId, int orderItemId, decimal price);
        Task UpdateQuantityAsync(int orderId, int orderItemId, decimal quantity);
    }
}
