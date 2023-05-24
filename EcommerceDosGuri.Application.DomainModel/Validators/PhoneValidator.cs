using EcommerceDosGuri.Application.DomainModel.ValueObjects;
using FluentValidation;
using System.Text.RegularExpressions;

namespace EcommerceDosGuri.Application.DomainModel.Validators
{
    public class PhoneValidator : AbstractValidator<Phone>
    {
        public PhoneValidator()
        {
            RuleFor(phone => phone.Number).Must(IsValidPhoneNumber)
                .WithMessage("Invalid phone number.");
        }

        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            var regularExpression = @"^[1-9]{2}(?:[2-8]|9[1-9])[0-9]{3}[0-9]{4}$";
            return Regex.IsMatch(phoneNumber, regularExpression);
        }
    }
}
