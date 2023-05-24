using System;

namespace EcommerceDosGuri.Application.UseCase.UseCase.Customers.GetAllCustomers
{
    public class GetAllCustomersPortOut
    {
        public GetAllCustomersPortOut(Guid id, string name, string email, bool isActive)
        {
            Id = id;
            Name = name;
            Email = email;
            IsActive = isActive;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
    }
}
