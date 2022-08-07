using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Locadora.WebApp.Domain.Models;

namespace Locadora.WebApp.Infrastructure.Configuration
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
        }
    }
}
