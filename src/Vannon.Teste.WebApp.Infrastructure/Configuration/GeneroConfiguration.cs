using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vannon.Teste.WebApp.Domain.Models;

namespace Vannon.Teste.WebApp.Infrastructure.Configuration
{
    public class GeneroConfiguration : IEntityTypeConfiguration<GeneroModel>
    {
        public void Configure(EntityTypeBuilder<GeneroModel> builder)
        {
            builder.HasKey(p => p.IdGenero);

            builder
                .Property(p => p.Descricao)
                .IsRequired();

            builder
                .Property(p => p.DataCriacao)
                .IsRequired();

            builder
                .HasMany(p => p.Filmes)
                .WithOne(l => l.Genero);
        }
    }
}
