using System;

namespace EcommerceDosGuri.Application.UseCase.UseCase.Products.AddProducts
{
    public class AddCustomerPortOut
    {
        public AddCustomerPortOut(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}
