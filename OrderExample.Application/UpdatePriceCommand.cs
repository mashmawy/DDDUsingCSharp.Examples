using MediatR;
using OrderExample.Services;

namespace OrderExample.Application
{
    public class UpdatePriceCommand : IRequest<bool>
    {
         

        public int OrderId { get; set; }
        public int OrderItemId { get; set; }
        public decimal Price { get; set; }
    }

    public class UpdatePriceCommandHandler : IRequestHandler<UpdatePriceCommand, bool>
    {
        private readonly IOrdersCommandsService ordersCommandsService;

        public UpdatePriceCommandHandler(IOrdersCommandsService ordersCommandsService)
        {
            this.ordersCommandsService = ordersCommandsService;
        }
        public async Task<bool> Handle(UpdatePriceCommand request, CancellationToken cancellationToken)
        {
            await ordersCommandsService.UpdatePriceAsync(request.OrderId, request.OrderItemId, request.Price);
            return true;
        }
    }
}