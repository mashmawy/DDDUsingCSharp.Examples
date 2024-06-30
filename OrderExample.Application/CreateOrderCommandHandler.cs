using MediatR;
using OrderExample.Services;

namespace OrderExample.Application
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, bool>
    {
        private readonly IOrdersCommandsService service;

        public CreateOrderCommandHandler(IOrdersCommandsService service)
        {
            this.service = service;
        }
        public async Task<bool> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            await service.CreateOrderAsync(request);
            return true;

        }
    }


}
