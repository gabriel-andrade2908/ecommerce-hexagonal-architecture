using AutoMapper;
using EcommerceDosGuri.Application.DomainModel.Administration;
using EcommerceDosGuri.Application.DomainModel.Catalog;
using EcommerceDosGuri.Application.UseCase.UseCase.Customers.GetAllCustomers;
using EcommerceDosGuri.Application.UseCase.UseCase.Customers.GetCustomerById;
using EcommerceDosGuri.Application.UseCase.UseCase.Products.GetAllProducts;
using EcommerceDosGuri.Application.UseCase.UseCase.Products.GetProductById;

namespace Vale.ECOS.Noise.Integration.Application.Interfaces.Mappers
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<Product, GetAllProductsPortOut>();
            CreateMap<Product, GetProductByIdPortOut>();
            CreateMap<Customer, GetCustomerByIdPortOut>();
            CreateMap<Customer, GetAllCustomersPortOut>();
        }
    }
}
