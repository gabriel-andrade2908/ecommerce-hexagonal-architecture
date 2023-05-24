using AutoMapper;
using EcommerceDosGuri.Application.DomainModel.Administration;
using EcommerceDosGuri.Application.UseCase.Ports.Out;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EcommerceDosGuri.Application.UseCase.UseCase.Customers.GetAllCustomers
{
    public class GetAllCustomersInterector : IGetAllCustomersInterector
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;

        public GetAllCustomersInterector(ICustomerRepository repository,
            IMapper mapper)
        {
            _customerRepository = repository;
            _mapper = mapper;
        }

        public async Task<IReadOnlyCollection<GetAllCustomersPortOut>> ExecuteAsync()
        {
            IReadOnlyCollection<Customer> customers = await _customerRepository.GetAllAsync();

            return _mapper.Map<IReadOnlyCollection<GetAllCustomersPortOut>>(customers);
        }
    }
}
