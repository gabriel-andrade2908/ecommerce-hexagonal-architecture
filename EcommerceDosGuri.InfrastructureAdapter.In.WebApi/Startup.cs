using EcommerceDosGuri.Application.UseCase;
using EcommerceDosGuri.InfrastructureAdapter.In.WebApi.Configurations;
using EcommerceDosGuri.InfrastructureAdapter.Out.AccessData;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace EcommerceDosGuri.InfrastructureAdapter.In.WebApi
{
    public class Startup
    {
        private const string CorsPolicyName = "ValePolicy";

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApiControllers();
            services.ConfigureSwagger();
            services.ConfigCors(CorsPolicyName);
            services.ResolveDependencyInjection();
            services.AddDomainDependencyInjection();
            services.AddInfrastructureDependencyInjection();
            services.AddAutoMapper();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.GetApiBasicConfiguration(env, CorsPolicyName);
        }
    }
}
