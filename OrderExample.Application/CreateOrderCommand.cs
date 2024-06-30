using MediatR;
using OrderExample.Services;

namespace OrderExample.Application
{
    public class CreateOrderCommand:OrderDto,IRequest<bool>
    {

    }


}
