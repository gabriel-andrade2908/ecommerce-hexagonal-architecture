using EcommerceDosGuri.Application.DomainModel.Administration;
using EcommerceDosGuri.Application.UseCase.Interfaces.Services;
using EcommerceDosGuri.Application.UseCase.Ports.Out;
using EcommerceDosGuri.Application.UseCase.Services.DomainNotifications;
using System;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace EcommerceDosGuri.Application.UseCase.UseCase.Customers.AddCustomers
{
    public class AddCustomerInterector : IAddCostumerInterector
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IDomainNotificationService _domainNotificationService;

        public AddCustomerInterector(ICustomerRepository repository,
            IDomainNotificationService domainNotificationService)
        {
            _customerRepository = repository;
            _domainNotificationService = domainNotificationService;
        }

        public async Task<AddCustomerPortOut> ExecuteAsync(AddCustomerPortIn dataPortIn)
        {
            var customer = new Customer(dataPortIn.Name, dataPortIn.Document,
                dataPortIn.Email, dataPortIn.Phone);

            if (customer.IsInvalid)
            {
                _domainNotificationService.AddNotification(new DomainNotification(HttpStatusCode.BadRequest,
                    customer.ValidationErrors.Select(x => x.ErrorMessage).ToList()));

                return new AddCustomerPortOut(Guid.Empty);
            }

            await _customerRepository.AddAsync(customer);

            return new AddCustomerPortOut(customer.Id);
        }
    }
}
