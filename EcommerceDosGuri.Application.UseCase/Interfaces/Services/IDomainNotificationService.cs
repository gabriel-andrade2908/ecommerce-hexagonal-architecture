using EcommerceDosGuri.Application.UseCase.Services.DomainNotifications;
using System.Collections.Generic;

namespace EcommerceDosGuri.Application.UseCase.Interfaces.Services
{
    public interface IDomainNotificationService
    {
        IReadOnlyCollection<DomainNotification> GetNotifications();
        void AddNotification(DomainNotification notification);
    }
}
