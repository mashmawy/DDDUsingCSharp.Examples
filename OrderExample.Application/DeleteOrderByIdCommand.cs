using MediatR;
using OrderExample.Services;

namespace OrderExample.Application
{
    public class DeleteOrderByIdCommand :  IRequest<bool>
    { 
         
        public int OrderId { get; set; }
    }
    public class DeleteOrderByIdCommandHandler : IRequestHandler<DeleteOrderByIdCommand, bool>
    {
        private readonly IOrdersCommandsService ordersCommandsService;

        public DeleteOrderByIdCommandHandler(IOrdersCommandsService ordersCommandsService)
        {
            this.ordersCommandsService = ordersCommandsService;
        }
        public async Task<bool> Handle(DeleteOrderByIdCommand request, CancellationToken cancellationToken)
        {
            await ordersCommandsService.DeleteOrderByIdAsync(request.OrderId);
            return true;
        }
    }
  
}