using Locadora.WebApp.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Locadora.WebApp.Infrastructure.Contexts
{
    public class MainContext : DbContext
    {
        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<AddressModel> Enderecos { get; set; }
        public DbSet<ContactModel> Contatos { get; set; }
        public DbSet<ClienteModel> Clientes { get; set; }
        public DbSet<LocacaoModel> Locacoes { get; set; }
        public DbSet<LocacaoFilmes> LocacaoFilmes { get; set; }
        public DbSet<FilmeModel> Filmes { get; set; }
        public DbSet<GeneroModel> Generos { get; set; }

        public MainContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContactModel>()
               .HasOne(p => p.Cliente)
               .WithOne(l => l.Contato)
               .HasPrincipalKey<ContactModel>(f => f.IdContato)
               .HasForeignKey<ClienteModel>(l => l.ClienteIdContato);

            modelBuilder.Entity<AddressModel>()
               .HasOne(p => p.Cliente)
               .WithOne(l => l.Endereco)
               .HasPrincipalKey<AddressModel>(f => f.IdEndereco)
               .HasForeignKey<ClienteModel>(f => f.ClienteIdEndereco);

            modelBuilder.Entity<LocacaoFilmes>()
                .HasKey(bc => new { bc.LocacaoId, bc.FilmeId });

            modelBuilder.Entity<LocacaoFilmes>()
                .HasOne(bc => bc.Filme)
                .WithMany(b => b.LocacaoFilmes)
                .HasForeignKey(bc => bc.FilmeId);

            modelBuilder.Entity<LocacaoFilmes>()
                .HasOne(bc => bc.Locacao)
                .WithMany(b => b.LocacaoFilmes)
                .HasForeignKey(bc => bc.LocacaoId);

            modelBuilder.Entity<GeneroModel>()
              .HasMany<FilmeModel>(p => p.Filmes)
              .WithOne(l => l.Genero)
              .HasPrincipalKey(k => k.IdGenero)
              .HasForeignKey(f => f.FilmeIdGenero);
        }
    }
}
