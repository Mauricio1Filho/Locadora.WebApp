using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Locadora.WebApp.Domain.Interfaces;
using Locadora.WebApp.Domain.Repositories;
using Locadora.WebApp.Domain.Services;
using Locadora.WebApp.Infrastructure.Contexts;
using Locadora.WebApp.Infrastructure.Repositories;
using Locadora.WebApp.Domain.Models;
using Locadora.WebApp.ViewModel;

namespace Locadora.WebApp
{
    public class Startup
    {
        public Startup(IHostEnvironment hostEnvironment, IConfiguration configuration)
        {
            Configuration = configuration;
            var builder = new ConfigurationBuilder()
               .SetBasePath(hostEnvironment.ContentRootPath)
               .AddJsonFile("appsettings.json", true, true)
               .AddJsonFile($"appsettings.{hostEnvironment.EnvironmentName}.json", true, false)
               .AddEnvironmentVariables();

            Configuration = builder.Build();
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews().AddRazorRuntimeCompilation();

            var connection = Configuration["ConnectionStrings:VannonDb"];
            services.AddDbContext<MainContext>(options =>
                options.
                UseMySql(connection));

            services.AddDbContext<MainContext>(
                options => options.UseMySql("ConnectionStrings:VannonDb"));

            services.AddTransient<IClienteRepository, ClienteRepository>();
            services.AddTransient<ILoginRepository, LoginRepository>();
            services.AddTransient<IFilmeRepository, FilmeRepository>();
            services.AddTransient<ILocacaoRepository, LocacaoRepository>();
            services.AddTransient<IUsuarioRepository, UsuarioRepository>();

            services.AddScoped<IClienteService, ClienteService>();
            services.AddScoped<ILoginService, LoginService>();
            services.AddScoped<IFilmeService, FilmeService>();
            services.AddScoped<ILocacaoService, LocacaoService>();
            services.AddScoped<IUsuarioService, UsuarioService>();
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseDefaultFiles();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "Login",
                    pattern: "{controller=Login}/{action=Index}/");
                endpoints.MapControllerRoute(
                    name: "Booking",
                    pattern: "{controller=Booking}/{action=Index}/{id?}");
                endpoints.MapControllerRoute(
                    name: "Client",
                    pattern: "{controller=Client}/{action=Index}/{id?}");
                endpoints.MapControllerRoute(
                    name: "Success",
                    pattern: "{controller=Success}/{action=Index}/{id?}");
            });
        }
    }
}
