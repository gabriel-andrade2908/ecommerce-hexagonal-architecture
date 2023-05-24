using EcommerceDosGuri.Application.DomainModel.ValueObjects;
using FluentValidation;

namespace EcommerceDosGuri.Application.DomainModel.Validators
{
    public class AddressValidator : AbstractValidator<Address>
    {
        public AddressValidator()
        {
            RuleFor(Address => Address.Country).NotEmpty()
                .WithMessage("Country is invalid.");
            RuleFor(Address => Address.State).NotEmpty()
                .WithMessage("State is invalid.");
            RuleFor(Address => Address.City).NotEmpty()
                .WithMessage("City is invalid.");
            RuleFor(Address => Address.Neighborhood).NotEmpty()
                .WithMessage("Neighborhood is invalid.");
            RuleFor(Address => Address.Street).NotEmpty()
                .WithMessage("Street is invalid.");
            RuleFor(Address => Address.Number).NotEmpty()
                .WithMessage("Number is invalid.");
        }
    }
}
