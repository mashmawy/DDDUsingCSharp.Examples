namespace OrderExample.Domain
{
    public class ShippingAddress : ValueObject
    {
        public string Country { get;private set; }
        public string Province { get; private set; }

        public string City { get; private set; }

        public string Street { get; private set; }

        public string Building { get; private set; }

        public string Apartment { get; private set; }
        public ShippingAddress() { }
        public ShippingAddress(string country, string province, string city, string street, string building, string apartment)
        {
            Country = country;
            Province = province;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }
        protected override IEnumerable<object> GetObjectValues()
        {
            return new List<object>()
            {
                Country,
                Province,
                City,
                Street,
                Building,
                Apartment
            };
        }
    }
}