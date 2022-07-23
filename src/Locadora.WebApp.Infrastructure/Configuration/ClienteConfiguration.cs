using Locadora.WebApp.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Locadora.WebApp.Infrastructure.Configuration
{
    public class ClienteConfiguration : IEntityTypeConfiguration<ClienteModel>
    {
        public void Configure(EntityTypeBuilder<ClienteModel> builder)
        {
            builder.HasKey(p => p.IdCliente);

            builder
                .Property(p => p.DataCriacao)
                .IsRequired();

            builder
                .Property(p => p.Cpf)
                .HasMaxLength(20)
                .IsRequired();

            builder
               .Property(p => p.Nome)
               .HasMaxLength(50)
               .IsRequired();
        }
    }
}
