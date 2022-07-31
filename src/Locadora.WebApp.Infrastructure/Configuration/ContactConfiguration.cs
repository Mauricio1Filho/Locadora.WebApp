using Locadora.WebApp.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Locadora.WebApp.Infrastructure.Configuration
{
    public class ContactConfiguration : IEntityTypeConfiguration<ContactModel>
    {
        public void Configure(EntityTypeBuilder<ContactModel> builder)
        {
            builder.HasKey(p => p.IdContato);

            builder
                .Property(p => p.Email)
                .HasMaxLength(128)
                .IsRequired();

            builder
                .Property(p => p.Celular)
                .HasMaxLength(20);
        }
    }
}
