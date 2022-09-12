using Locadora.WebApp.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

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
                .Property(p => p.Titulo)
                .HasMaxLength(50)
                .IsRequired();
            builder.HasData(
                new FilmeModel
                {
                    IdFilme = 1,
                    Titulo = "IT: A Coisa",
                    FilmeIdGenero = 1,
                    DataCriacao = DateTime.Now
                },
                new FilmeModel
                {
                    IdFilme = 2,
                    Titulo = "John Wick 3: Parabellum",
                    FilmeIdGenero = 2,
                    DataCriacao = DateTime.Now
                },
                new FilmeModel
                {
                    IdFilme = 3,
                    Titulo = "O Homem do Norte",
                    FilmeIdGenero = 3,
                    DataCriacao = DateTime.Now
                });
        }
    }
}
