using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Locadora.WebApp.Domain.Models;

namespace Locadora.WebApp.Infrastructure.Configuration
{
    public class LocacaoConfiguration : IEntityTypeConfiguration<LocacaoModel>
    {
        public void Configure(EntityTypeBuilder<LocacaoModel> builder)
        {
            builder.HasKey(p => p.IdLocacao);

            builder
                .Property(p => p.DataCriacao)
                .IsRequired();

            //builder
            //    .HasMany(p => p.Filmes)
            //    .WithOne(l => l.Locacao)
            //    .HasPrincipalKey(k => k.IdLocacao)
            //    .HasForeignKey(f => f.IdFilme)
            //    .HasConstraintName("FK_Locacao_Filme");
        }
    }
}
