using MediatR;
using OrderExample.Services;

namespace OrderExample.Application
{
    public class GetOrderListQueryHandler : IRequestHandler<GetOrdersListQuery, IEnumerable<OrderDto>>
    {
        private readonly IOrderQueriesService service;

        public GetOrderListQueryHandler(IOrderQueriesService service)
        {
            this.service = service;
        }
        public async Task<IEnumerable<OrderDto>> Handle(GetOrdersListQuery request, CancellationToken cancellationToken)
        {
            return await this.service.GetOrdersList();
        }
    }
}
