using Locadora.WebApp.Domain.Interfaces;
using Locadora.WebApp.Domain.Repositories;
using Locadora.WebApp.Domain.Services;
using Locadora.WebApp.Infrastructure.Contexts;
using Locadora.WebApp.Infrastructure.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using Pomelo.EntityFrameworkCore.MySql;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace Locadora.WebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.ConfigureAppConfiguration((hostingContext, config) =>
                    {
                        var env = hostingContext.HostingEnvironment;
                        config.AddJsonFile("appsettings.json", true, true)
                              .AddJsonFile($"appsettings.{env.EnvironmentName}.json", true, true)
                              .AddEnvironmentVariables();
                    })
                    .ConfigureServices((hostingContext, services) =>
                    {
                        services.AddControllersWithViews().AddRazorRuntimeCompilation();
                        services.AddDbContext<MainContext>(options =>
                            options.UseMySql(hostingContext.Configuration.GetConnectionString("LocadoraDb"),
                            ServerVersion.AutoDetect(hostingContext.Configuration.GetConnectionString("LocadoraDb"))));

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
                    })
                    .Configure((app) =>
                    {
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
                    });
                });
    }
}
