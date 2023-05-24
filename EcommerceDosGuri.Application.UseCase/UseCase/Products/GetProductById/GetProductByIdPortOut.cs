using System;

namespace EcommerceDosGuri.Application.UseCase.UseCase.Products.GetProductById
{
    public class GetProductByIdPortOut
    {
        public GetProductByIdPortOut(string name, double value, bool isAvailable,
            DateTime registrationDate)
        {
            Name = name;
            Value = value;
            IsAvailable = isAvailable;
            RegistrationDate = registrationDate;
        }

        public string Name { get; set; }
        public double Value { get; set; }
        public bool IsAvailable { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}
