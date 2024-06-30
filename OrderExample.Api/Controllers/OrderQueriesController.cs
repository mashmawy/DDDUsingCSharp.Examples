using MediatR;
using Microsoft.AspNetCore.Mvc;
using OrderExample.Application;
using OrderExample.Services;

namespace OrderExample.Api.Controllers
{
    [ApiController]
    public class OrdersQueriesController : ControllerBase
    {
        private readonly IMediator mediator;

        public OrdersQueriesController(
            IMediator mediator)
        {
            this.mediator = mediator;
        }

        [Route("/GetOrderByIdQuery")]
        [HttpGet]
        public async Task<OrderDto> GetOrderByIdQuery(int orderID)
        {
            return await mediator.Send(new GetOrderByIdQuery(orderID));
        }


        [Route("/GetOrdersItemsListQuery")]
        [HttpGet]
        public async Task<IEnumerable<OrderItemDto>> GetOrdersItemsListQuery(int orderID)
        {
            return await mediator.Send(new GetOrdersItemsListQuery(orderID));
        }


        [Route("/GetOrdersListQuery")]
        [HttpGet]
        public async Task<IEnumerable<OrderDto>> GetOrdersListQuery()
        {
            return await mediator.Send(new GetOrdersListQuery());
        }


    }
}
