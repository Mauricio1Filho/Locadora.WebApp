using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Locadora.WebApp.Domain.Models;

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

            builder
                .Property(p => p.IdGenero)
                .IsRequired();

            builder
                .HasOne(p => p.Genero)
                .WithMany(l => l.Filmes)
                .HasForeignKey(p => p.IdGenero);
        }
    }
}
