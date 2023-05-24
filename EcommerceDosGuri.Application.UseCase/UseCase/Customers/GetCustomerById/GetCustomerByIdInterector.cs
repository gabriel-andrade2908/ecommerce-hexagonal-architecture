using AutoMapper;
using EcommerceDosGuri.Application.DomainModel.Administration;
using EcommerceDosGuri.Application.UseCase.Interfaces.Services;
using EcommerceDosGuri.Application.UseCase.Internationalization;
using EcommerceDosGuri.Application.UseCase.Ports.Out;
using EcommerceDosGuri.Application.UseCase.Services.DomainNotifications;
using System.Net;
using System.Threading.Tasks;

namespace EcommerceDosGuri.Application.UseCase.UseCase.Customers.GetCustomerById
{
    public class GetCustomerByIdInterector : IGetCustomerByIdInterector
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;
        private readonly IDomainNotificationService _domainNotificationService;
        const string InterectorObject = "Customer";

        public GetCustomerByIdInterector(ICustomerRepository repository, IMapper mapper,
            IDomainNotificationService domainNotificationService)
        {
            _customerRepository = repository;
            _mapper = mapper;
            _domainNotificationService = domainNotificationService;
        }

        public async Task<GetCustomerByIdPortOut> ExecuteAsync(GetCustomerByIdPortIn dataPortIn)
        {
            Customer customer = await _customerRepository.GetByIdAsync(dataPortIn.id);

            if (customer == null)
            {
                _domainNotificationService.AddNotification(new DomainNotification(HttpStatusCode.NotFound,
                   ResponseMessages.NotFound));

                return new GetCustomerByIdPortOut();
            }

            return _mapper.Map<GetCustomerByIdPortOut>(customer);
        }
    }
}
