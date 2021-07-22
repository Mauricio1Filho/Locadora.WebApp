using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vannon.Teste.WebApp.Domain.Models;

namespace Vannon.Teste.WebApp.Infrastructure.Configuration
{
    public class ReservaConfiguration : IEntityTypeConfiguration<ReservaModel>
    {
        public void Configure(EntityTypeBuilder<ReservaModel> builder)
        {
           builder .HasKey(p => new { p.IdFilme, p.IdCliente });

            builder
                .Property(p => p.IdFilme)
                .IsRequired();

            builder
                .Property(p => p.IdCliente)
                .IsRequired();

            builder
                .HasOne(p => p.Cliente)
                .WithMany(p => p.Reservas)
                .HasForeignKey(f => f.IdCliente);

            builder
                .HasOne(p => p.Filme)
                .WithMany(p => p.Reservas)
                .HasForeignKey(f => f.IdFilme);
        }
    }
}
