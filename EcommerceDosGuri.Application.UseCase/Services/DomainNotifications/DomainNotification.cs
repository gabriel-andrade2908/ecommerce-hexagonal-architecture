using System.Collections.Generic;
using System.Net;

namespace EcommerceDosGuri.Application.UseCase.Services.DomainNotifications
{
    public class DomainNotification
    {
        public HttpStatusCode HttpStatusCode { get; private set; }
        public IList<string> Message { get; private set; }
        internal DomainNotification(HttpStatusCode httpStatusCode, IList<string> message)
        {
            HttpStatusCode = httpStatusCode;
            Message = message;
        }

        internal DomainNotification(HttpStatusCode httpStatusCode, string message)
        {
            HttpStatusCode = httpStatusCode;
            Message = new List<string> { message };
        }
    }
}
