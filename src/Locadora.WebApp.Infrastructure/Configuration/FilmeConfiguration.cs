using Locadora.WebApp.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Locadora.WebApp.Infrastructure.Configuration
{
    public class FilmeConfiguration : IEntityTypeConfiguration<FilmeModel>
    {
        public void Configure(EntityTypeBuilder<FilmeModel> builder)
        {
            builder.HasKey(p => p.IdFilme);

            builder
                .Property(p => p.DataCriacao)
                .IsRequired();

            builder
                .Property(p => p.Preco)
                .IsRequired();
            
            builder
                .Property(p => p.Titulo)
                .HasMaxLength(50)
                .IsRequired();            
        }
    }
}
