using EcommerceDosGuri.Application.UseCase.Interfaces.Services;
using System.Collections.Generic;
using System.Linq;

namespace EcommerceDosGuri.Application.UseCase.Services.DomainNotifications
{
    public class DomainNotificationService : IDomainNotificationService
    {
        private readonly IList<DomainNotification> _domainNotifications;

        public DomainNotificationService()
        {
            _domainNotifications = new List<DomainNotification>();
        }

        public IReadOnlyCollection<DomainNotification> GetNotifications() => _domainNotifications.ToList();
        public void AddNotification(DomainNotification notification) => _domainNotifications.Add(notification);
    }
}
