﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Locadora.WebApp.Infrastructure.Contexts;

namespace Locadora.WebApp.Infrastructure.Migrations
{
    [DbContext(typeof(MainContext))]
    [Migration("20220419005617_Migration_MySQL")]
    partial class Migration_MySQL
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Locadora.WebApp.Domain.Models.ClienteModel", b =>
                {
                    b.Property<long>("IdCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("varchar(20) CHARACTER SET utf8mb4")
                        .HasMaxLength(20);

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.HasKey("IdCliente");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Locadora.WebApp.Domain.Models.FilmeModel", b =>
                {
                    b.Property<long>("IdFilme")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime(6)");

                    b.Property<long>("IdGenero")
                        .HasColumnType("bigint");

                    b.Property<double>("Preco")
                        .HasColumnType("double");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.HasKey("IdFilme");

                    b.HasIndex("IdGenero");

                    b.ToTable("Filmes");

                    b.HasData(
                        new
                        {
                            IdFilme = 1L,
                            DataCriacao = new DateTime(2022, 4, 18, 21, 56, 16, 609, DateTimeKind.Local).AddTicks(5839),
                            IdGenero = 3L,
                            Preco = 14.99,
                            Titulo = "Viuva Negra"
                        },
                        new
                        {
                            IdFilme = 2L,
                            DataCriacao = new DateTime(2022, 4, 18, 21, 56, 16, 609, DateTimeKind.Local).AddTicks(6304),
                            IdGenero = 2L,
                            Preco = 19.989999999999998,
                            Titulo = "Space Jam: Um Novo Legado"
                        });
                });

            modelBuilder.Entity("Locadora.WebApp.Domain.Models.GeneroModel", b =>
                {
                    b.Property<long>("IdGenero")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("IdGenero");

                    b.ToTable("Generos");

                    b.HasData(
                        new
                        {
                            IdGenero = 1L,
                            DataCriacao = new DateTime(2022, 4, 18, 21, 56, 16, 606, DateTimeKind.Local).AddTicks(5672),
                            Descricao = "Terror"
                        },
                        new
                        {
                            IdGenero = 2L,
                            DataCriacao = new DateTime(2022, 4, 18, 21, 56, 16, 607, DateTimeKind.Local).AddTicks(5276),
                            Descricao = "Comedia"
                        },
                        new
                        {
                            IdGenero = 3L,
                            DataCriacao = new DateTime(2022, 4, 18, 21, 56, 16, 607, DateTimeKind.Local).AddTicks(5300),
                            Descricao = "Acao"
                        },
                        new
                        {
                            IdGenero = 4L,
                            DataCriacao = new DateTime(2022, 4, 18, 21, 56, 16, 607, DateTimeKind.Local).AddTicks(5303),
                            Descricao = "Drama"
                        });
                });

            modelBuilder.Entity("Locadora.WebApp.Domain.Models.LocacaoModel", b =>
                {
                    b.Property<long>("IdLocacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime(6)");

                    b.Property<long>("IdCliente")
                        .HasColumnType("bigint");

                    b.HasKey("IdLocacao");

                    b.HasIndex("IdCliente");

                    b.ToTable("Locacoes");
                });

            modelBuilder.Entity("Locadora.WebApp.Domain.Models.ReservaModel", b =>
                {
                    b.Property<long>("IdFilme")
                        .HasColumnType("bigint");

                    b.Property<long>("IdLocacao")
                        .HasColumnType("bigint");

                    b.Property<long?>("ClienteModelIdCliente")
                        .HasColumnType("bigint");

                    b.HasKey("IdFilme", "IdLocacao");

                    b.HasIndex("ClienteModelIdCliente");

                    b.HasIndex("IdLocacao");

                    b.ToTable("Reservas");
                });

            modelBuilder.Entity("Locadora.WebApp.Domain.Models.UsuarioModel", b =>
                {
                    b.Property<long>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.HasKey("IdUsuario");

                    b.ToTable("Usuarios");

                    b.HasData(
                        new
                        {
                            IdUsuario = 1L,
                            DataCriacao = new DateTime(2022, 4, 18, 21, 56, 16, 608, DateTimeKind.Local).AddTicks(9155),
                            Login = "admin@admin.com",
                            Nome = "Administrador",
                            Senha = "admin"
                        });
                });

            modelBuilder.Entity("Locadora.WebApp.Domain.Models.FilmeModel", b =>
                {
                    b.HasOne("Locadora.WebApp.Domain.Models.GeneroModel", "Genero")
                        .WithMany("Filmes")
                        .HasForeignKey("IdGenero")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Locadora.WebApp.Domain.Models.LocacaoModel", b =>
                {
                    b.HasOne("Locadora.WebApp.Domain.Models.ClienteModel", "Cliente")
                        .WithMany("Locacoes")
                        .HasForeignKey("IdCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Locadora.WebApp.Domain.Models.ReservaModel", b =>
                {
                    b.HasOne("Locadora.WebApp.Domain.Models.ClienteModel", null)
                        .WithMany("Reservas")
                        .HasForeignKey("ClienteModelIdCliente");

                    b.HasOne("Locadora.WebApp.Domain.Models.FilmeModel", "Filme")
                        .WithMany("Reservas")
                        .HasForeignKey("IdFilme")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Locadora.WebApp.Domain.Models.LocacaoModel", "Locacao")
                        .WithMany("Reservas")
                        .HasForeignKey("IdLocacao")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}