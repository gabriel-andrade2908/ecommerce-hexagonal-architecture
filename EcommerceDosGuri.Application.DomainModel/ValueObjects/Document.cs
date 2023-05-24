using EcommerceDosGuri.Application.DomainModel.BaseValueObject;
using EcommerceDosGuri.Application.DomainModel.Validators;

namespace EcommerceDosGuri.Application.DomainModel.ValueObjects
{
    public class Document : ValueObject
    {
        public Document(string cpf, string cnpj)
        {
            Cpf = cpf;
            Cnpj = cnpj;

            Validate(this, new DocumentValidator());
        }

        public string Cpf { get; set; }
        public string Cnpj { get; set; }
    }
}
