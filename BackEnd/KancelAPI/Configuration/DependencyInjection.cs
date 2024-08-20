using KancelAPI.Interfaces.Repository.Administration;
using KancelAPI.Repository.Administration;
using KancelAPI.Services.IService.Administration;
using KancelAPI.Services.Service.Administration;

namespace KancelAPI.Configuration
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            //Administration
            services.AddScoped<IApplicationUserService, ApplicationUserService>();
            services.AddScoped<IApplicationUserRepository, ApplicationUserRepository>();

            return services;
        }
    }
}
