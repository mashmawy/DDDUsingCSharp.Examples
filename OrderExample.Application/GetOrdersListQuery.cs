using MediatR;
using OrderExample.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderExample.Application
{
    public class GetOrdersListQuery:IRequest<IEnumerable<OrderDto>>
    {
    }
}
