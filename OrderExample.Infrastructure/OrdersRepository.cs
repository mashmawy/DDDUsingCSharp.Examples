using OrderExample.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderExample.Infrastructure
{
    public class OrdersRepository  : IOrdersRepository
    {
        readonly OrderDbContext _dbContext;
        public OrdersRepository(OrderDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void AddOrder(Order order)
        {
            _dbContext.Orders.Add(order);
        }

        public void DeleteOrder(Order order)
        {
            _dbContext.Remove(order);
        }

        public void UpdateOrder(Order order)
        {
            var dbOrder = FindOrder(order.Id);
            ArgumentNullException.ThrowIfNull(dbOrder, nameof(order)); 
            _dbContext.Entry(dbOrder).CurrentValues.SetValues(order);
        }

        public Order? FindOrder(int id)
        {
            return _dbContext.Orders.Find(id);
        }
        public IEnumerable<Order> Search(Func<Order, bool> predecit)
        {
            return _dbContext.Orders.Where(predecit);
        }


    }
}
