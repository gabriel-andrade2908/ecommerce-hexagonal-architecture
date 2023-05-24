using EcommerceDosGuri.InfrastructureAdapter.In.WebApi.Handlers;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

namespace EcommerceDosGuri.InfrastructureAdapter.In.WebApi.Configurations
{
    public static class ApiServiceConfigBuilder
    {
        public static void ResolveDependencyInjection(this IServiceCollection services)
        {
            services.AddMvc(options => options.Filters.Add<NotificationFilter>());
        }

        public static void AddApiControllers(this IServiceCollection services)
        {
            services.AddControllers(opts =>
            {
                opts.ModelBinderProviders.Insert(0, new DateTimeModelBinderProvider());
            }).AddNewtonsoftJson(jsonOptions =>
            {
                jsonOptions.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
                jsonOptions.SerializerSettings.MissingMemberHandling = MissingMemberHandling.Ignore;
                jsonOptions.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Serialize;
            });
        }

        public static void ConfigCors(this IServiceCollection services, string policyName)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(policyName,
                    builder =>
                    {
                        builder
#if DEBUG
                            .AllowAnyMethod()
                            .AllowAnyHeader()
                            .AllowAnyOrigin()
#endif
                            .WithExposedHeaders("X-Total-Count");
                    });
            });
        }

        public static void ConfigureSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.OrderActionsBy(apiDesc =>
                        $"{apiDesc.ActionDescriptor.RouteValues["controller"]}_{apiDesc.HttpMethod}");
                c.CustomSchemaIds(x => x.FullName);
            });
        }
    }
}