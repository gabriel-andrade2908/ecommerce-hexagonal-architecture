using EcommerceDosGuri.Application.UseCase.Ports.Out;
using System;
using System.Threading.Tasks;

namespace EcommerceDosGuri.Application.UseCase.UseCase.Products.AddProducts
{
    public class AddCustomerInterector : IAddCostumerInterector
    {
        private readonly IProductRepository _repository;

        public AddCustomerInterector(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<AddCustomerPortOut> ExecuteAsync(AddCustomerPortIn dataPortIn)
        {
            //Product product = Product.CreateNewProduct(dataPortIn.Name, dataPortIn.Value);

            //await _repository.AddAsync(product);

            return new AddCustomerPortOut(Guid.NewGuid());
        }
    }
}
