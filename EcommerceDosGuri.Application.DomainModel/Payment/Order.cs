using EcommerceDosGuri.Application.DomainModel.Administration;
using EcommerceDosGuri.Application.DomainModel.BaseEntity;
using EcommerceDosGuri.Application.DomainModel.Catalog;
using System;

namespace EcommerceDosGuri.Application.DomainModel.Payment
{
    public class Order : Entity
    {
        public Order(Guid customerId, Guid productId, int productQuantity,
            decimal totalValue)
        {
            CustomerId = customerId;
            ProductId = productId;
            ProductQuantity = productQuantity;
            TotalValue = totalValue;
        }

        public Guid CustomerId { get; private set; }
        public Guid ProductId { get; private set; }
        public int ProductQuantity { get; private set; }
        public decimal TotalValue { get; private set; }
        public Customer Customer { get; private set; }
        public Product Product { get; private set; }
        public string Status { get; private set; } //TODO: Create enum
    }
}
