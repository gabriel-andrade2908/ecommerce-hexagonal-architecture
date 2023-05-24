using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace EcommerceDosGuri.InfrastructureAdapter.In.WebApi.Configurations
{
    public static class ApiConfiguration
    {
        private const string ApiVersion = "v1";
        private const string ApiName = "EcommerceDosGuri.Api";

        public static void GetApiBasicConfiguration(this IApplicationBuilder app, IWebHostEnvironment env, string policyName)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();
            else
                app.UseHsts();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseStaticFiles();

            app.UseEndpoints(endpoints => endpoints.MapControllers());

            app.UseCors(policyName);

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                // c.SwaggerEndpoint(ApiVersion, $"{ApiName}");
                c.SwaggerEndpoint($"{ApiVersion}/swagger.json", ApiName);
            });
        }
    }
}