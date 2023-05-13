using OrderExample.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderExample.Services
{

    public class OrdersCommandsService : IOrdersCommandsService
    {
        private readonly IOrdersRepository ordersRepository;

        public OrdersCommandsService(IOrdersRepository ordersRepository)
        {
            this.ordersRepository = ordersRepository;
        }
        public async Task CreateOrderAsync(OrderDto orderDto)
        {
            ShippingAddress shippingAddress = orderDto.GetShippingDomainEntity();
            Order order = new Order(orderDto.OrderNumber, orderDto.OrderDate, shippingAddress);
            this.ordersRepository.AddOrder(order);
            await this.ordersRepository.SaveChanges();
        }

        public async Task UpdateOrderShippingAddressAsync(ShippingAddressDto shippingAddressDto)
        {
            var order = this.ordersRepository.FindOrder(shippingAddressDto.Id);
            order.UpdateShippingAddress(shippingAddressDto.GetShippingDomainEntity());
            await this.ordersRepository.SaveChanges();
        }

        public async Task DeleteOrderByIdAsync(int id)
        {
            var order = this.ordersRepository.FindOrder(id);
            this.ordersRepository.DeleteOrder(order);
            await this.ordersRepository.SaveChanges();
        }

        public async Task AddOrderItemAsync(OrderItemDto orderItemDto)
        {
            var order = this.ordersRepository.FindOrder(orderItemDto.OrderId);
            order?.AddOrderItem(orderItemDto.ItemDescription, orderItemDto.ItemPrice, orderItemDto.Quantity);
            await this.ordersRepository.SaveChanges();
        }
        public async Task UpdatePriceAsync(int orderId, int orderItemId, decimal price)
        {
            var order = this.ordersRepository.FindOrder(orderId);
            var orderItem = order.OrderItems.SingleOrDefault(p => p.Id == orderItemId);
            orderItem.UpdatePrice(price);
            await this.ordersRepository.SaveChanges();
        }

        public async Task UpdateQuantityAsync(int orderId, int orderItemId, decimal quantity)
        {
            var order = this.ordersRepository.FindOrder(orderId);
            var orderItem = order.OrderItems.SingleOrDefault(p => p.Id == orderItemId);
            orderItem.UpdateQuantity(quantity);
            await this.ordersRepository.SaveChanges();
        }

        public async Task FixItemDescriptionAsync(int orderId, int orderItemId, string fixedItemDescription)
        {
            var order = this.ordersRepository.FindOrder(orderId);
            var orderItem = order.OrderItems.SingleOrDefault(p => p.Id == orderItemId);
            orderItem.FixItemDescription(fixedItemDescription);
            await this.ordersRepository.SaveChanges();
        }

    }
}
