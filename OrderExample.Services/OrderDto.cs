using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderExample.Services
{
    public class OrderDto : ShippingAddressDto
    {
        public string OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }



    }
}
