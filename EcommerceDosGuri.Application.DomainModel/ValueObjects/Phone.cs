using EcommerceDosGuri.Application.DomainModel.BaseValueObject;
using EcommerceDosGuri.Application.DomainModel.Validators;

namespace EcommerceDosGuri.Application.DomainModel.ValueObjects
{
    public class Phone : ValueObject
    {
        public Phone(string number)
        {
            Number = number;

            Validate(this, new PhoneValidator());
        }

        public string Number { get; set; }
    }
}
