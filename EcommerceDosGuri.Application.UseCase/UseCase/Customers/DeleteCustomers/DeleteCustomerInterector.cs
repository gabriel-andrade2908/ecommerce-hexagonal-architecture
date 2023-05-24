using EcommerceDosGuri.Application.DomainModel.Administration;
using EcommerceDosGuri.Application.UseCase.Interfaces.Services;
using EcommerceDosGuri.Application.UseCase.Internationalization;
using EcommerceDosGuri.Application.UseCase.Ports.Out;
using EcommerceDosGuri.Application.UseCase.Services.DomainNotifications;
using System.Net;
using System.Threading.Tasks;

namespace EcommerceDosGuri.Application.UseCase.UseCase.Customers.DeleteCustomers
{
    public class DeleteCustomerInterector : IDeleteCustomerInterector
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IDomainNotificationService _domainNotificationService;
        const string InterectorObject = "Customer";

        public DeleteCustomerInterector(ICustomerRepository repository,
            IDomainNotificationService domainNotificationService)
        {
            _customerRepository = repository;
            _domainNotificationService = domainNotificationService;
        }

        public async Task ExecuteAsync(DeleteCustomerPortIn dataPortIn)
        {
            Customer customer = await _customerRepository.GetByIdAsync(dataPortIn.Id);

            if (customer == null)
            {
                _domainNotificationService.AddNotification(new DomainNotification(HttpStatusCode.NotFound,
                    string.Format(ResponseMessages.NotFound, InterectorObject)));

                return;
            }

            await _customerRepository.DeleteAsync(customer);
        }
    }
}
