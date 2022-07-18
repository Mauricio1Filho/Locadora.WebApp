using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Vannon.Teste.WebApp.Domain.Interfaces;
using Vannon.Teste.WebApp.Domain.Repositories;
using Vannon.Teste.WebApp.Domain.Services;
using Vannon.Teste.WebApp.Infrastructure.Contexts;
using Vannon.Teste.WebApp.Infrastructure.Repositories;

namespace Vannon.Teste.WebApp
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
            services.AddControllersWithViews().AddRazorRuntimeCompilation();

            var connection = Configuration["ConnectionStrings:VannonDb"];
            services.AddDbContext<MainContext>(options =>
                options.UseMySql(connection));

            services.AddDbContext<MainContext>(
                options => options.UseMySql("ConnectionStrings:VannonDb"));

            services.AddTransient<IClienteRepository, ClienteRepository>();
            services.AddTransient<ILoginRepository, LoginRepository>();
            services.AddTransient<IFilmeRepository, FilmeRepository>();
            services.AddTransient<ILocacaoRepository, LocacaoRepository>();
            services.AddTransient<IReservaRepository, ReservaRepository>();
            services.AddTransient<IUsuarioRepository, UsuarioRepository>();

            services.AddScoped<IClienteService, ClienteService>();
            services.AddScoped<ILoginService, LoginService>();
            services.AddScoped<IFilmeService, FilmeService>();
            services.AddScoped<ILocacaoService, LocacaoService>();
            services.AddScoped<IReservaService, ReservaService>();
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
                    name: "Default",
                    pattern: "{controller=Login}/{action=Index}");
            });
        }
    }
}
