using MediatR;
using OrderExample.Services;

namespace OrderExample.Application
{
    public class AddOrderItemCommand : OrderItemDto, IRequest<bool>
    {

    }
    public class AddOrderItemCommandHandler : IRequestHandler<AddOrderItemCommand, bool>
    {
        private readonly IOrdersCommandsService ordersCommandsService;

        public AddOrderItemCommandHandler(IOrdersCommandsService ordersCommandsService)
        {
            this.ordersCommandsService = ordersCommandsService;
        }
        public async Task<bool> Handle(AddOrderItemCommand request, CancellationToken cancellationToken)
        {
            await ordersCommandsService.AddOrderItemAsync(request);
            return true;
        }
    }
}