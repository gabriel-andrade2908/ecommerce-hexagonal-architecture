using EcommerceDosGuri.Application.DomainModel.ValueObjects;
using FluentValidation;

namespace EcommerceDosGuri.Application.DomainModel.Validators
{
    public class EmailValidator : AbstractValidator<Email>
    {
        public EmailValidator()
        {
            RuleFor(email => email.Address).EmailAddress()
                .WithMessage("Email address is invalid.");
        }
    }
}
