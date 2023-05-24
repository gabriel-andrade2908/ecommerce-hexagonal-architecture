using AutoMapper;
using EcommerceDosGuri.Application.DomainModel.Catalog;
using EcommerceDosGuri.Application.UseCase.Ports.Out;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EcommerceDosGuri.Application.UseCase.UseCase.Products.GetAllProducts
{
    public class GetAllProductsInterector : IGetAllProductsInterector
    {
        private readonly IProductRepository _repository;
        private readonly IMapper _mapper;

        public GetAllProductsInterector(IProductRepository repository,
            IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IReadOnlyCollection<GetAllProductsPortOut>> ExecuteAsync()
        {
            IReadOnlyCollection<Product> products = await _repository.GetAllAsync();

            return _mapper.Map<IReadOnlyCollection<GetAllProductsPortOut>>(products);
        }
    }
}
