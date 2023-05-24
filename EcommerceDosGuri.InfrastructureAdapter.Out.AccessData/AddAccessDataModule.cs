using EcommerceDosGuri.Application.UseCase.Ports.Out;
using EcommerceDosGuri.InfrastructureAdapter.Out.AccessData.EntityFramework.Contexts;
using EcommerceDosGuri.InfrastructureAdapter.Out.AccessData.EntityFramework.Customers;
using Microsoft.Extensions.DependencyInjection;

namespace EcommerceDosGuri.InfrastructureAdapter.Out.AccessData
{
    public static class AddAccessDataModule
    {
        public static void AddInfrastructureDependencyInjection(this IServiceCollection services)
        {
            services.AddDbContext<AppDb>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
        }
    }
}
