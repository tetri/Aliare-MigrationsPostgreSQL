
using System;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using MigrationsPostgre.Models;

namespace MigrationsPostgre
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddApplicationInsightsTelemetry();

            // Add framework services.
            services.AddMvc();

            services
                .AddEntityFrameworkNpgsql().AddDbContext<FuncionarioContext>(opt => opt.UseNpgsql(Configuration.GetConnectionString("FuncionariosDB"),
                                                                                        b => b.SetPostgresVersion(new Version(9, 6)))
                                                                                       /* NÃO RESOLVE .UseLowerCaseNamingConvention()*/);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, FuncionarioContext dataContext)
        {
            // migrate any database changes on startup (includes initial db creation)
            dataContext.Database.Migrate();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Funcionarios}/{action=Index}/{id?}");
            });
        }
    }
}
