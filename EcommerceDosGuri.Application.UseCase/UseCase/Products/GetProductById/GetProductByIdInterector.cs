using AutoMapper;
using EcommerceDosGuri.Application.DomainModel.Catalog;
using EcommerceDosGuri.Application.UseCase.Ports.Out;
using System;
using System.Threading.Tasks;

namespace EcommerceDosGuri.Application.UseCase.UseCase.Products.GetProductById
{
    public class GetProductByIdInterector : IGetProductByIdInterector
    {
        private readonly IProductRepository _repository;
        private readonly IMapper _mapper;

        public GetProductByIdInterector(IProductRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GetProductByIdPortOut> ExecuteAsync(Guid id)
        {
            Product product = await _repository.GetByIdAsync(id);

            return _mapper.Map<GetProductByIdPortOut>(product);
        }
    }
}
