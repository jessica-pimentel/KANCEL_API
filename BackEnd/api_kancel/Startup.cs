using api_kancel.Configuration;
using infra_kancel.Context;
using infra_kancel.Context.Factory;
using infra_kancel.Context.Interface;
using Microsoft.AspNetCore.Connections;
using Microsoft.EntityFrameworkCore;

namespace api_kancel
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddInfrastructureServices();
            services.AddSingleton<IDbConnectionFactory, DbConnectionFactory>();

            services.AddDbContext<KancelContext>(options =>
                options.UseSqlite(Configuration.GetConnectionString("DefaultConnection")));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error"); 
                app.UseHsts();
            }

            string dbPath = Path.Combine(env.ContentRootPath, "DB");
            if (!Directory.Exists(dbPath))
            {
                Directory.CreateDirectory(dbPath);
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
