using EcommerceDosGuri.Application.DomainModel.BaseEntity;
using EcommerceDosGuri.Application.DomainModel.Payment;
using EcommerceDosGuri.Application.DomainModel.ValueObjects;
using System.Collections.Generic;

namespace EcommerceDosGuri.Application.DomainModel.Administration
{
    public class Customer : Entity
    {
        public Customer(string name, string document, string email, string phoneNumber)
        {
            Document documentValueObject = BuildDocument(document);
            Email emailValueObject = BuildEmail(email);
            Phone phoneValueObject = BuildPhone(phoneNumber);

            Name = name;
            Document = documentValueObject.Cpf;
            Email = emailValueObject.Address;
            PhoneNumber = phoneValueObject.Number;

            ValidationErrors.AddRange(documentValueObject.ValidationErrors);
            ValidationErrors.AddRange(emailValueObject.ValidationErrors);
            ValidationErrors.AddRange(phoneValueObject.ValidationErrors);
        }

        public string Name { get; private set; }
        public string Document { get; private set; }
        public string Email { get; private set; }
        public string PhoneNumber { get; private set; }
        public IReadOnlyCollection<Order> Orders { get; private set; }

        private static Document BuildDocument(string document)
        {
            return new Document(document, document);
        }

        private static Email BuildEmail(string email)
        {
            return new Email(email);
        }

        private static Phone BuildPhone(string phone)
        {
            return new Phone(phone);
        }
    }
}
