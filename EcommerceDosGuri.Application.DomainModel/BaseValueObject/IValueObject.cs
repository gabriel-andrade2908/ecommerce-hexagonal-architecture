using FluentValidation;

namespace EcommerceDosGuri.Application.DomainModel.BaseValueObject
{
    public interface IValueObject
    {
        void Validate<TValueObject>(TValueObject model, AbstractValidator<TValueObject> validator);
    }
}
