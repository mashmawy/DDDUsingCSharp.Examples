using DDDUsingCSharp.Examples.Example2.Domain;

namespace DDDUsingCSharp.Examples.Example2.Infrastructure
{
    public interface IOrdersRepository
    {
        void AddOrder(Order order);
        void DeleteOrder(Order order);
        Order? FindOrder(int id);
        IEnumerable<Order> Search(Func<Order, bool> predecit);
        void UpdateOrder(Order order);
    }
}
