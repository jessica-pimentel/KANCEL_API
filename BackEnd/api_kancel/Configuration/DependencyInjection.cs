using domain_kancel.Interfaces.Repository.Administration;
using domain_kancel.Service;
using infra_kancel.Repository.Administration;

namespace api_kancel.Configuration
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
