using Locadora.WebApp.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Locadora.WebApp.Infrastructure.Configuration
{
    public class AddressConfiguration : IEntityTypeConfiguration<AddressModel>
    {
        public void Configure(EntityTypeBuilder<AddressModel> builder)
        {
            builder.HasKey(p => p.IdEndereco);                   

            builder
                .Property(p => p.Endereco)
                .HasMaxLength(128)
                .IsRequired();

            builder
                .Property(p => p.Numero)                
                .IsRequired();

            builder
               .Property(p => p.Bairro)
               .HasMaxLength(128)
               .IsRequired();

            builder
              .Property(p => p.CEP)
              .HasMaxLength(8)
              .IsRequired();

            builder
              .Property(p => p.Cidade)
              .HasMaxLength(30)
              .IsRequired();

            builder
              .Property(p => p.Estado)
              .HasMaxLength(20)
              .IsRequired();

        }
    }
}
