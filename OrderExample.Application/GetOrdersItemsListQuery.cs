using MediatR;
using OrderExample.Services;

namespace OrderExample.Application
{
    public class GetOrdersItemsListQuery : IRequest<IEnumerable<OrderItemDto>>
    {
        public GetOrdersItemsListQuery(int orderID)
        {
            OrderID = orderID;
        }

        public int OrderID { get; }
    }
    public class GetOrdersItemsListQueryHandler : IRequestHandler<GetOrdersItemsListQuery, IEnumerable<OrderItemDto>>
    {
        private readonly IOrderQueriesService orderQueriesService;

        public GetOrdersItemsListQueryHandler(IOrderQueriesService orderQueriesService)
        {
            this.orderQueriesService = orderQueriesService;
        }
        public async Task<IEnumerable<OrderItemDto>> Handle(GetOrdersItemsListQuery request, CancellationToken cancellationToken)
        {
            return await orderQueriesService.GetOrdersItemsList(request.OrderID);

        }
    }
}
