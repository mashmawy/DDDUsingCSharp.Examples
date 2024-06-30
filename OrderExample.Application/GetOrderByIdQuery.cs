using MediatR;
using OrderExample.Services;

namespace OrderExample.Application
{
    public class GetOrderByIdQuery :  IRequest<OrderDto>
    {
        public GetOrderByIdQuery(int orderID)
        {
            OrderID = orderID;
        }

        public int OrderID { get; }
    }



    public class GetOrderByIdQueryHandler : IRequestHandler<GetOrderByIdQuery, OrderDto>
    {
        private readonly IOrderQueriesService orderQueriesService;

        public GetOrderByIdQueryHandler(IOrderQueriesService orderQueriesService)
        {
            this.orderQueriesService = orderQueriesService;
        }
        public async Task<OrderDto> Handle(GetOrderByIdQuery request, CancellationToken cancellationToken)
        {
            return await orderQueriesService.GetOrderById(request.OrderID);

        }
    }
  
}
