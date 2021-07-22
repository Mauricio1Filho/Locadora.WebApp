using Microsoft.EntityFrameworkCore;
using System;
using Vannon.Teste.WebApp.Domain.Models;
using Vannon.Teste.WebApp.Infrastructure.Configuration;

namespace Vannon.Teste.WebApp.Infrastructure.Contexts
{
    public class MainContext : DbContext
    {
        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<ClienteModel> Clientes { get; set; }
        public DbSet<LocacaoModel> Locacoes { get; set; }
        public DbSet<ReservaModel> Reservas { get; set; }
        public DbSet<FilmeModel> Filmes { get; set; }
        public DbSet<GeneroModel> Generos { get; set; }

        public MainContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new ClienteConfiguration());
            modelBuilder.ApplyConfiguration(new FilmeConfiguration());
            modelBuilder.ApplyConfiguration(new GeneroConfiguration());
            modelBuilder.ApplyConfiguration(new LocacaoConfiguration());
            modelBuilder.ApplyConfiguration(new ReservaConfiguration());

            modelBuilder.Entity<GeneroModel>().HasData(
                new GeneroModel()
                {
                    IdGenero = 1,
                    Descricao = "Terror",
                    DataCriacao = DateTime.Now
                },
                new GeneroModel()
                {
                    IdGenero = 2,
                    Descricao = "Comedia",
                    DataCriacao = DateTime.Now
                },
                new GeneroModel()
                {
                    IdGenero = 3,
                    Descricao = "Acao",
                    DataCriacao = DateTime.Now
                },
                new GeneroModel()
                {
                    IdGenero = 4,
                    Descricao = "Drama",
                    DataCriacao = DateTime.Now
                });

            modelBuilder.Entity<UsuarioModel>().HasData(
                new UsuarioModel()
                {
                    IdUsuario = 1,
                    Nome = "Administrador",
                    Login = "admin@admin.com",
                    Senha = "admin",
                    DataCriacao = DateTime.Now
                });

            modelBuilder.Entity<FilmeModel>().HasData(
                new FilmeModel()
                {
                    IdFilme = 1,
                    IdGenero = 3,
                    Preco = 14.99,
                    Titulo = "Viuva Negra",
                    DataCriacao = DateTime.Now
                },
                new FilmeModel()
                {
                    IdFilme = 2,
                    IdGenero = 2,
                    Preco = 19.99,
                    Titulo = "Space Jam: Um Novo Legado",
                    DataCriacao = DateTime.Now
                });

            base.OnModelCreating(modelBuilder);
        }
    }
}
