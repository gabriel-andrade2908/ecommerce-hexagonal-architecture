using System;

namespace EcommerceDosGuri.Application.UseCase.UseCase.Products.GetAllProducts
{
    public class GetAllProductsPortOut
    {
        public GetAllProductsPortOut(Guid id, string name, double value, bool isAvailable,
            DateTime registrationDate)
        {
            Id = id;
            Name = name;
            Value = value;
            IsAvailable = isAvailable;
            RegistrationDate = registrationDate;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Value { get; set; }
        public bool IsAvailable { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}
