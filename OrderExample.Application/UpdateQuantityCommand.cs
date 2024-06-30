using MediatR;
using OrderExample.Services;

namespace OrderExample.Application
{
    public class UpdateQuantityCommand : IRequest<bool>
    {

        public UpdateQuantityCommand(int orderId, int orderItemId, decimal quantity)
        {
            OrderId = orderId;
            OrderItemId = orderItemId;
            Quantity = quantity;
        }

        public int OrderId { get; }
        public int OrderItemId { get; }
        public decimal Quantity { get; }
    }

    public class UpdateQuantityCommandHandler : IRequestHandler<UpdateQuantityCommand, bool>
    {
        private readonly IOrdersCommandsService ordersCommandsService;

        public UpdateQuantityCommandHandler(IOrdersCommandsService ordersCommandsService)
        {
            this.ordersCommandsService = ordersCommandsService;
        }
        public async Task<bool> Handle(UpdateQuantityCommand request, CancellationToken cancellationToken)
        {
            await ordersCommandsService.UpdateQuantityAsync(request.OrderId, request.OrderItemId, request.Quantity);
            return true;
        }
    }
}