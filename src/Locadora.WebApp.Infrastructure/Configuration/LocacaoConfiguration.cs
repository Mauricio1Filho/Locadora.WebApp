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
        }
    }
}
