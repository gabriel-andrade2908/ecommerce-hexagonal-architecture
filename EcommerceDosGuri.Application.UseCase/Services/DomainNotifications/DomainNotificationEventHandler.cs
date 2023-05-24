using EcommerceDosGuri.Application.UseCase.Events.DomainNotifications;
using EcommerceDosGuri.Application.UseCase.Interfaces.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace EcommerceDosGuri.Application.UseCase.Services.DomainNotifications
{
    internal class DomainNotificationEventHandler : INotificationHandler<DomainNotificationEvent>
    {
        private readonly IDomainNotificationService _domainNotificationSerivce;
        public DomainNotificationEventHandler(IDomainNotificationService domainNotificationSerivce)
        {
            _domainNotificationSerivce = domainNotificationSerivce;
        }

        public Task Handle(DomainNotificationEvent notification, CancellationToken cancellationToken)
        {
            _domainNotificationSerivce.AddNotification(new DomainNotification(notification.HttpStatusCode,
                notification.Message));

            return Task.CompletedTask;
        }
    }
}
