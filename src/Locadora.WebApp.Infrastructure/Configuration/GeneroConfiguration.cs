using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Locadora.WebApp.Domain.Models;
using System;

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
            builder.HasData(
                new GeneroModel
                {
                    IdGenero = 1,
                    Descricao = "Terror",
                    DataCriacao = DateTime.Now
                },
                new GeneroModel
                {
                    IdGenero = 2,
                    Descricao = "Ação",
                    DataCriacao = DateTime.Now
                },
                new GeneroModel
                {
                    IdGenero = 3,
                    Descricao = "Drama",
                    DataCriacao = DateTime.Now
                }
            );
        }
    }
}
