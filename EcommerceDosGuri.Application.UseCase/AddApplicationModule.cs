using AutoMapper;
using EcommerceDosGuri.Application.UseCase.Interfaces.Services;
using EcommerceDosGuri.Application.UseCase.Services.DomainNotifications;
using EcommerceDosGuri.Application.UseCase.UseCase.Customers.AddCustomers;
using EcommerceDosGuri.Application.UseCase.UseCase.Customers.DeleteCustomers;
using EcommerceDosGuri.Application.UseCase.UseCase.Customers.GetAllCustomers;
using EcommerceDosGuri.Application.UseCase.UseCase.Customers.GetCustomerById;
using EcommerceDosGuri.Application.UseCase.UseCase.Customers.UpdateCustomers;
using Microsoft.Extensions.DependencyInjection;
using Vale.ECOS.Noise.Integration.Application.Interfaces.Mappers;

namespace EcommerceDosGuri.Application.UseCase
{
    public static class AddApplicationModule
    {
        public static void AddDomainDependencyInjection(this IServiceCollection services)
        {
            services.AddScoped<IDomainNotificationService, DomainNotificationService>();
            services.AddScoped<IGetAllCustomersInterector, GetAllCustomersInterector>();
            services.AddScoped<IGetCustomerByIdInterector, GetCustomerByIdInterector>();
            services.AddScoped<IAddCostumerInterector, AddCustomerInterector>();
            services.AddScoped<IUpdateCustomerInterector, UpdateCustomerInterector>();
            services.AddScoped<IDeleteCustomerInterector, DeleteCustomerInterector>();
        }

        public static void AddAutoMapper(this IServiceCollection services)
        {
            var mapperConfig = new MapperConfiguration(mc => { mc.AddProfile(new AutoMapping()); });

            var mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}
