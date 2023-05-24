using EcommerceDosGuri.Application.DomainModel.Administration;
using EcommerceDosGuri.Application.DomainModel.Validators;
using EcommerceDosGuri.Application.DomainModel.ValueObjects;
using EcommerceDosGuri.Application.UseCase.Interfaces.Services;
using EcommerceDosGuri.Application.UseCase.Internationalization;
using EcommerceDosGuri.Application.UseCase.Ports.Out;
using EcommerceDosGuri.Application.UseCase.Services.DomainNotifications;
using FluentValidation.Results;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace EcommerceDosGuri.Application.UseCase.UseCase.Customers.UpdateCustomers
{
    public class UpdateCustomerInterector : IUpdateCustomerInterector
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IDomainNotificationService _domainNotificationService;
        const string InterectorObject = "Customer";

        public UpdateCustomerInterector(ICustomerRepository repository,
            IDomainNotificationService domainNotificationService)
        {
            _customerRepository = repository;
            _domainNotificationService = domainNotificationService;
        }

        public async Task ExecuteAsync(UpdateCustomerPortIn dataPortIn)
        {
            Customer customer = await _customerRepository.GetByIdAsync(dataPortIn.Id);

            if (customer == null)
            {
                _domainNotificationService.AddNotification(new DomainNotification(HttpStatusCode.NotFound,
                   string.Format(ResponseMessages.NotFound, InterectorObject)));

                return;
            }

            IList<ValidationFailure> validationErrors = await ValidateCustomerUpdateAsync(dataPortIn.Email,
                dataPortIn.PhoneNumber);

            if (validationErrors.Any())
            {
                _domainNotificationService.AddNotification(new DomainNotification(HttpStatusCode.BadRequest,
                    validationErrors.Select(x => x.ErrorMessage).ToList()));

                return;
            }

            var newCustomer = new Customer(dataPortIn.Name, customer.Document, dataPortIn.Email,
                dataPortIn.PhoneNumber);

            //customer.Name = dataPortIn.Name;
            //customer.Email = dataPortIn.Email;
            //customer.PhoneNumber = dataPortIn.PhoneNumber;

            await _customerRepository.UpdateAsync(customer);
        }

        private static async Task<IList<ValidationFailure>> ValidateCustomerUpdateAsync(string email, string phoneNumber)
        {
            var validationErrors = new List<ValidationFailure>();

            var emailValidation = await new EmailValidator().ValidateAsync(new Email(email));
            var phoneValidation = await new PhoneValidator().ValidateAsync(new Phone(phoneNumber));

            validationErrors.AddRange(emailValidation.Errors);
            validationErrors.AddRange(phoneValidation.Errors);

            return validationErrors;
        }
    }
}
