﻿// <auto-generated />
using System;
using Locadora.WebApp.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Locadora.WebApp.Infrastructure.Migrations
{
    [DbContext(typeof(MainContext))]
    partial class MainContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Locadora.WebApp.Domain.Models.AddressModel", b =>
                {
                    b.Property<int>("IdEndereco")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.HasKey("IdEndereco");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("Locadora.WebApp.Domain.Models.ClienteModel", b =>
                {
                    b.Property<int>("IdCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ClienteIdContato")
                        .HasColumnType("int");

                    b.Property<int>("ClienteIdEndereco")
                        .HasColumnType("int");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("IdCliente");

                    b.HasIndex("ClienteIdContato")
                        .IsUnique();

                    b.HasIndex("ClienteIdEndereco")
                        .IsUnique();

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Locadora.WebApp.Domain.Models.ContactModel", b =>
                {
                    b.Property<int>("IdContato")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Celular")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("IdContato");

                    b.ToTable("Contatos");
                });

            modelBuilder.Entity("Locadora.WebApp.Domain.Models.FilmeModel", b =>
                {
                    b.Property<int>("IdFilme")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("FilmeIdGenero")
                        .HasColumnType("int");

                    b.Property<double>("Preco")
                        .HasColumnType("double");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("IdFilme");

                    b.HasIndex("FilmeIdGenero");

                    b.ToTable("Filmes");
                });

            modelBuilder.Entity("Locadora.WebApp.Domain.Models.GeneroModel", b =>
                {
                    b.Property<int>("IdGenero")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("IdGenero");

                    b.ToTable("Generos");
                });

            modelBuilder.Entity("Locadora.WebApp.Domain.Models.LocacaoFilmes", b =>
                {
                    b.Property<int>("LocacaoId")
                        .HasColumnType("int");

                    b.Property<int>("FilmeId")
                        .HasColumnType("int");

                    b.HasKey("LocacaoId", "FilmeId");

                    b.HasIndex("FilmeId");

                    b.ToTable("LocacaoFilmes");
                });

            modelBuilder.Entity("Locadora.WebApp.Domain.Models.LocacaoModel", b =>
                {
                    b.Property<int>("IdLocacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("ClienteIdCliente")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime(6)");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("IdLocacao");

                    b.HasIndex("ClienteIdCliente");

                    b.ToTable("Locacoes");
                });

            modelBuilder.Entity("Locadora.WebApp.Domain.Models.UsuarioModel", b =>
                {
                    b.Property<int>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Login")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Senha")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("IdUsuario");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Locadora.WebApp.Domain.Models.ClienteModel", b =>
                {
                    b.HasOne("Locadora.WebApp.Domain.Models.ContactModel", "Contato")
                        .WithOne("Cliente")
                        .HasForeignKey("Locadora.WebApp.Domain.Models.ClienteModel", "ClienteIdContato")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Locadora.WebApp.Domain.Models.AddressModel", "Endereco")
                        .WithOne("Cliente")
                        .HasForeignKey("Locadora.WebApp.Domain.Models.ClienteModel", "ClienteIdEndereco")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Locadora.WebApp.Domain.Models.FilmeModel", b =>
                {
                    b.HasOne("Locadora.WebApp.Domain.Models.GeneroModel", "Genero")
                        .WithMany("Filmes")
                        .HasForeignKey("FilmeIdGenero")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Locadora.WebApp.Domain.Models.LocacaoFilmes", b =>
                {
                    b.HasOne("Locadora.WebApp.Domain.Models.FilmeModel", "Filme")
                        .WithMany("LocacaoFilmes")
                        .HasForeignKey("FilmeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Locadora.WebApp.Domain.Models.LocacaoModel", "Locacao")
                        .WithMany("LocacaoFilmes")
                        .HasForeignKey("LocacaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Locadora.WebApp.Domain.Models.LocacaoModel", b =>
                {
                    b.HasOne("Locadora.WebApp.Domain.Models.ClienteModel", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteIdCliente");
                });
#pragma warning restore 612, 618
        }
    }
}
