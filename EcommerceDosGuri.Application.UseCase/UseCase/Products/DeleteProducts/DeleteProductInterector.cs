using EcommerceDosGuri.Application.DomainModel.Catalog;
using EcommerceDosGuri.Application.UseCase.Ports.Out;
using EcommerceDosGuri.Application.UseCase.UseCase.Customers.DeleteCustomers;
using System;
using System.Threading.Tasks;

namespace EcommerceDosGuri.Application.UseCase.UseCase.Products.DeleteProducts
{
    public class DeleteProductInterector : IDeleteCustomerInterector
    {
        private readonly IProductRepository _repository;

        public DeleteProductInterector(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task ExecuteAsync(DeleteCustomerPortIn dataPortIn)
        {
            Product product = await _repository.GetByIdAsync(dataPortIn.Id);

            if (product == null)
                throw new Exception();//tratar

            await _repository.DeleteAsync(product);
        }
    }
}
