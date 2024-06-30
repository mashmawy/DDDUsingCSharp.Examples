using MediatR;
using Microsoft.AspNetCore.Mvc;
using OrderExample.Application;

namespace OrderExample.Api.Controllers
{

    [ApiController]
    public class OrdersCommandsController : ControllerBase
    {
        private readonly IMediator mediator;

        public OrdersCommandsController(
            IMediator mediator)
        {
            this.mediator = mediator;
        }

        [Route("/CreateOrderCommand")]
        [HttpPost]
        public async Task<bool> CreateOrderCommand(CreateOrderCommand createOrderCommand)
        {
            return await mediator.Send(createOrderCommand);
        }

        [Route("/DeleteOrderByIdCommand")]
        [HttpPost]
        public async Task<bool> DeleteOrderByIdCommand(DeleteOrderByIdCommand deleteOrderByIdCommand)
        {
            return await mediator.Send(deleteOrderByIdCommand);
        }

        [Route("/UpdateOrderShippingAddressCommand")]
        [HttpPost]
        public async Task<bool> UpdateOrderShippingAddressCommand(UpdateOrderShippingAddressCommand updateOrderShippingAddressCommand)
        {
            return await mediator.Send(updateOrderShippingAddressCommand);
        }


        [Route("/UpdatePriceCommand")]
        [HttpPost]
        public async Task<bool> UpdatePriceCommand(UpdatePriceCommand updatePriceCommand)
        {
            return await mediator.Send(updatePriceCommand);
        }


        [Route("/UpdateQuantityCommand")]
        [HttpPost]
        public async Task<bool> UpdateQuantityCommand(UpdateQuantityCommand updateQuantityCommand)
        {
            return await mediator.Send(updateQuantityCommand);
        }

        [Route("/AddOrderItemCommand")]
        [HttpPost]
        public async Task<bool> AddOrderItemCommand(AddOrderItemCommand addOrderItemCommand)
        {
            return await mediator.Send(addOrderItemCommand);
        }




    }
}
