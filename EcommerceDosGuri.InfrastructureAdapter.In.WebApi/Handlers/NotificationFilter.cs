using EcommerceDosGuri.Application.UseCase.Interfaces.Services;
using EcommerceDosGuri.Application.UseCase.Services.DomainNotifications;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace EcommerceDosGuri.InfrastructureAdapter.In.WebApi.Handlers
{
    public class NotificationFilter : IAsyncResultFilter
    {
        private const string LanguageHeader = "Accept-Language";
        private readonly IDomainNotificationService _domainNotificationService;

        public NotificationFilter(IDomainNotificationService domainNotificationService)
        {
            _domainNotificationService = domainNotificationService;
        }

        public async Task OnResultExecutionAsync(ResultExecutingContext context, ResultExecutionDelegate next)
        {
            SetCulture(context.HttpContext.Request.Headers);

            IReadOnlyCollection<DomainNotification> notifications = _domainNotificationService
                .GetNotifications();

            if (notifications.Any())
            {
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                context.HttpContext.Response.ContentType = "application/json";

                string notificationsJson = JsonConvert.SerializeObject(notifications);
                await context.HttpContext.Response.WriteAsync(notificationsJson);

                return;
            }

            await next();
        }

        private static void SetCulture(IHeaderDictionary headers)
        {
            if (headers[LanguageHeader].Count <= 0) return;

            string language = headers[LanguageHeader].First();
            CultureInfo culture;
            try
            {
                culture = CultureInfo.CreateSpecificCulture(language);
            }
            catch (CultureNotFoundException)
            {
                culture = CultureInfo.CreateSpecificCulture("en");
            }

            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;
        }
    }
}