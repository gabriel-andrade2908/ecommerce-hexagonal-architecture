using FluentValidation;
using FluentValidation.Results;
using System.Collections.Generic;
using System.Linq;

namespace EcommerceDosGuri.Application.DomainModel.BaseValueObject
{
    public abstract class ValueObject : IValueObject
    {
        public List<ValidationFailure> ValidationErrors { get; private set; } = new();
        public bool IsInvalid => ValidationErrors.Any();

        public void Validate<TValueObject>(TValueObject model, AbstractValidator<TValueObject> validator)
        {
            ValidationErrors.AddRange(validator.Validate(model).Errors);
        }
    }
}
