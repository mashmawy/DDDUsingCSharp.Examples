namespace OrderExample.Domain
{
    public class Order : AggregateRoot
    {
        public string OrderNumber { get; private set; }
        public DateTime OrderDate { get; private set; }

        public ShippingAddress ShippingAddress { get; private set; }


        private readonly List<OrderItem> _orderItems = new List<OrderItem>();
        public IReadOnlyCollection<OrderItem> OrderItems => _orderItems;

        public Order() { }
        public Order(string orderNumber, DateTime orderDate, ShippingAddress shippingAddress )
        {
            OrderNumber = orderNumber;
            OrderDate = orderDate;
            ShippingAddress = shippingAddress; 
        }

        public void AddOrderItem(string itemDescription, decimal itemPrice, decimal quantity )
        {
            _orderItems.Add(new OrderItem(itemDescription, itemPrice, quantity));

        }

        public void RemoveOrderItem(OrderItem orderItem)
        {
            _orderItems.Remove(orderItem);
        }


        public void UpdateShippingAddress(string country, string province, string city, string street, string building, string apartment)
        {
            ShippingAddress = new ShippingAddress(country, province, city, street, building, apartment);
        }
        public void UpdateShippingAddress(ShippingAddress shippingAddress)
        {
            ShippingAddress = shippingAddress;
        }
    }
}