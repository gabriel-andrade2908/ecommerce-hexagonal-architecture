using EcommerceDosGuri.Application.DomainModel.BaseValueObject;
using EcommerceDosGuri.Application.DomainModel.Validators;

namespace EcommerceDosGuri.Application.DomainModel.ValueObjects
{
    public class Email : ValueObject
    {
        public Email(string address)
        {
            Address = address;

            Validate(this, new EmailValidator());
        }

        public string Address { get; set; }
    }
}
