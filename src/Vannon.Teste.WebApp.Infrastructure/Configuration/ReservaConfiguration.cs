using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vannon.Teste.WebApp.Domain.Models;

namespace Vannon.Teste.WebApp.Infrastructure.Configuration
{
    public class ReservaConfiguration : IEntityTypeConfiguration<ReservaModel>
    {
        public void Configure(EntityTypeBuilder<ReservaModel> builder)
        {
           builder .HasKey(p => new { p.IdFilme, p.IdLocacao });

            builder
                .Property(p => p.IdFilme)
                .IsRequired();

            builder
                .Property(p => p.IdLocacao)
                .IsRequired();

            builder
                .HasOne(p => p.Locacao)
                .WithMany(p => p.Reservas)
                .HasForeignKey(f => f.IdLocacao);

            builder
                .HasOne(p => p.Filme)
                .WithMany(p => p.Reservas)
                .HasForeignKey(f => f.IdFilme);
        }
    }
}
