using MediatR;
using System.Collections.Generic;
using System.Net;

namespace EcommerceDosGuri.Application.UseCase.Events.DomainNotifications
{
    public class DomainNotificationEvent : INotification
    {
        internal DomainNotificationEvent(HttpStatusCode httpStatusCode, IList<string> message)
        {
            HttpStatusCode = httpStatusCode;
            Message = message;
        }

        public HttpStatusCode HttpStatusCode { get; private set; }
        public IList<string> Message { get; private set; }
    }
}
