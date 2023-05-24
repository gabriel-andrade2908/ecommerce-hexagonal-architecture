using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace EcommerceDosGuri.Application.DomainModel.BaseEntity
{
    public abstract class Entity : IEntity
    {
        protected Entity()
        {
            Id = Guid.NewGuid();
            IsActive = true;
            CreationTime = DateTime.Now;
        }
        public Guid Id { get; private set; }
        public bool IsActive { get; private set; }
        public DateTime CreationTime { get; private set; }
        public DateTime? InativatedDate { get; private set; }

        [NotMapped]
        public List<ValidationFailure> ValidationErrors { get; private set; } = new();

        [NotMapped]
        public bool IsInvalid => ValidationErrors.Any();

        public void Inativate()
        {
            IsActive = false;
            InativatedDate = DateTime.Now;
        }

        public void Validate<TValueObject>(TValueObject model, AbstractValidator<TValueObject> validator)
        {
            ValidationErrors.AddRange(validator.Validate(model).Errors);
        }
    }
}
