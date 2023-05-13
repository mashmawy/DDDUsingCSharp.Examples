using Dapper;
using Microsoft.Data.SqlClient;

namespace OrderExample.Services
{

    public class OrderQueriesService : IOrderQueriesService
    {

        public async Task<IEnumerable<OrderDto>> GetOrdersList()
        {
            using (var connection = new SqlConnection("server=(local);database=OrderDB;Trusted_Connection=True;TrustServerCertificate=True;"))
            {
                string query = "select * from Orders";
                var reader = await connection.QueryMultipleAsync(query);
                var data = (reader.Read<OrderDto>());
                return data;
            }
        }


        public async Task<OrderDto> GetOrderById(int orderId)
        {
            using (var connection = new SqlConnection("server=(local);database=OrderDB;Trusted_Connection=True;TrustServerCertificate=True;"))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@OrderId", orderId);
                string query = @"  SELECT  *  FROM Orders where Id=@OrderId";
                var data = await connection.QuerySingleOrDefaultAsync<OrderDto>(query, parameters);
                return data;
            }
        }

        public async Task<IEnumerable<OrderItemDto>> GetOrdersItemsList(int orderId)
        {
            using (var connection = new SqlConnection("server=(local);database=OrderDB;Trusted_Connection=True;TrustServerCertificate=True;"))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@OrderId", orderId);
                string query = "select * from OrderItem where OrderId=@OrderId";
                var reader = await connection.QueryMultipleAsync(query, parameters);
                var data = (reader.Read<OrderItemDto>());
                return data;
            }
        }
    }
}
