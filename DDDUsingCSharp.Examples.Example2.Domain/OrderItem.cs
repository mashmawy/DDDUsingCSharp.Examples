namespace DDDUsingCSharp.Examples.Example2.Domain
{
    public class OrderItem : Entity
    {
        public string ItemDescription { get;private set; }
        public decimal ItemPrice { get;private set; }

        public decimal Quantity { get;private set; }

        public decimal Total { get;private set; }

        public OrderItem() { }
        public OrderItem(string itemDescription, decimal itemPrice, decimal quantity     )
        {
            ItemDescription = itemDescription;
            ItemPrice = itemPrice;
            Quantity = quantity;
            Total = itemPrice* quantity;
        }

        public void UpdatePrice(decimal price)
        {
            ItemPrice = price;
            Total = price * Quantity;
        }

        public void UpdateQuantity(decimal quantity)
        {
            Quantity = quantity;
            Total = ItemPrice * quantity;
        }

        public void FixItemDescription(string fixedItemDescription)
        {
            ItemDescription = fixedItemDescription;
        }
    }
}