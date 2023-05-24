using System;

namespace EcommerceDosGuri.Application.UseCase.UseCase.Customers.GetCustomerById
{
    public class GetCustomerByIdPortOut
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime InativatedDate { get; set; }
        public string Document { get; set; }
        public string PhoneNumber { get; set; }
    }
}
