using System;

namespace EcommerceDosGuri.Application.UseCase.UseCase.Products.UpdateProducts
{
    public class UpdateCustomerPortIn
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Value { get; set; }
        public bool IsAvailable { get; set; }
    }
}
