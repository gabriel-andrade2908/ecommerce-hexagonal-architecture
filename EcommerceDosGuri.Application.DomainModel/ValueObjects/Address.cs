using EcommerceDosGuri.Application.DomainModel.BaseValueObject;
using EcommerceDosGuri.Application.DomainModel.Validators;

namespace EcommerceDosGuri.Application.DomainModel.ValueObjects
{
    public class Address : ValueObject
    {
        public Address(string country, string state, string city, string neighborhood,
            string street, string number)
        {
            Country = country;
            State = state;
            City = city;
            Neighborhood = neighborhood;
            Street = street;
            Number = number;

            Validate(this, new AddressValidator());
        }

        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Neighborhood { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
    }
}
