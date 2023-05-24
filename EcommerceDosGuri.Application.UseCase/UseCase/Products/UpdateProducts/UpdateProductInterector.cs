using EcommerceDosGuri.Application.DomainModel.Catalog;
using EcommerceDosGuri.Application.UseCase.Ports.Out;
using System;
using System.Threading.Tasks;

namespace EcommerceDosGuri.Application.UseCase.UseCase.Products.UpdateProducts
{
    public class UpdateCustomerInterector : IUpdateCustomerInterector
    {
        private readonly IProductRepository _repository;

        public UpdateCustomerInterector(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task ExecuteAsync(UpdateCustomerPortIn dataPortIn)
        {
            Product product = await _repository.GetByIdAsync(dataPortIn.Id);

            if (product == null)
                throw new Exception(); // tratar

            await _repository.UpdateAsync(product);
        }
    }
}
