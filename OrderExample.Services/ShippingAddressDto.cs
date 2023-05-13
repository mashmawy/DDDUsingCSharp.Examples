using OrderExample.Domain;

namespace OrderExample.Services
{
    public class ShippingAddressDto
    {
        public int Id { get; set; }
        public string ShippingAddress_Country { get; set; }
        public string ShippingAddress_Province { get; set; }

        public string ShippingAddress_City { get; set; }

        public string ShippingAddress_Street { get; set; }

        public string ShippingAddress_Building { get; set; }

        public string ShippingAddress_Apartment { get; set; }

        internal ShippingAddress GetShippingDomainEntity()
        {
            return new ShippingAddress(ShippingAddress_Country, ShippingAddress_Province, ShippingAddress_City,
                ShippingAddress_Street, ShippingAddress_Building, ShippingAddress_Apartment);
        }
    }
}