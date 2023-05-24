using System;

namespace EcommerceDosGuri.Application.UseCase.UseCase.Customers.UpdateCustomers
{
    public class UpdateCustomerPortIn
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
