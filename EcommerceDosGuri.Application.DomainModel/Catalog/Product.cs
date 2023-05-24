using EcommerceDosGuri.Application.DomainModel.BaseEntity;
using EcommerceDosGuri.Application.DomainModel.Payment;
using System.Collections.Generic;

namespace EcommerceDosGuri.Application.DomainModel.Catalog
{
    public class Product : Entity
    {
        public Product(string name, double value)
        {
            Name = name;
            Value = value;
        }

        public string Name { get; private set; }
        public double Value { get; private set; }
        public int QuantityInStock { get; private set; }
        public IReadOnlyCollection<Order> Orders { get; private set; }
    }
}
