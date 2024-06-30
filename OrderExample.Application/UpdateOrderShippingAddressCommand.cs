using MediatR;
using OrderExample.Services;

namespace OrderExample.Application
{
    public class UpdateOrderShippingAddressCommand : ShippingAddressDto, IRequest<bool>
    {

    }

    public class UpdateOrderShippingAddressCommandHandler : IRequestHandler<UpdateOrderShippingAddressCommand, bool>
    {
        private readonly IOrdersCommandsService ordersCommandsService;

        public UpdateOrderShippingAddressCommandHandler(IOrdersCommandsService ordersCommandsService)
        {
            this.ordersCommandsService = ordersCommandsService;
        }
        public async Task<bool> Handle(UpdateOrderShippingAddressCommand request, CancellationToken cancellationToken)
        {
            await ordersCommandsService.UpdateOrderShippingAddressAsync(request);
            return true;
        }
    }


}