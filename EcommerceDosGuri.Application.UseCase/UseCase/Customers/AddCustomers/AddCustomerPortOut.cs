using System;

namespace EcommerceDosGuri.Application.UseCase.UseCase.Customers.AddCustomers
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
