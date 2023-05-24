using System;

namespace EcommerceDosGuri.Application.DomainModel.BaseEntity
{
    public interface IEntity
    {
        Guid Id { get; }
        void Inativate();
    }
}
