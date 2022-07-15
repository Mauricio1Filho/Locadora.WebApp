using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Vannon.Teste.WebApp.Infrastructure.Migrations
{
    public partial class Migration_MySQL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    IdCliente = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(maxLength: 50, nullable: false),
                    Cpf = table.Column<string>(maxLength: 20, nullable: false),
                    DataCriacao = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.IdCliente);
                });

            migrationBuilder.CreateTable(
                name: "Generos",
                columns: table => new
                {
                    IdGenero = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(nullable: false),
                    DataCriacao = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Generos", x => x.IdGenero);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    IdUsuario = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(maxLength: 50, nullable: false),
                    Login = table.Column<string>(maxLength: 50, nullable: false),
                    Senha = table.Column<string>(maxLength: 50, nullable: false),
                    DataCriacao = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.IdUsuario);
                });

            migrationBuilder.CreateTable(
                name: "Locacoes",
                columns: table => new
                {
                    IdLocacao = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdCliente = table.Column<long>(nullable: false),
                    DataCriacao = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locacoes", x => x.IdLocacao);
                    table.ForeignKey(
                        name: "FK_Locacoes_Clientes_IdCliente",
                        column: x => x.IdCliente,
                        principalTable: "Clientes",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Filmes",
                columns: table => new
                {
                    IdFilme = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Titulo = table.Column<string>(maxLength: 50, nullable: false),
                    IdGenero = table.Column<long>(nullable: false),
                    Preco = table.Column<double>(nullable: false),
                    DataCriacao = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filmes", x => x.IdFilme);
                    table.ForeignKey(
                        name: "FK_Filmes_Generos_IdGenero",
                        column: x => x.IdGenero,
                        principalTable: "Generos",
                        principalColumn: "IdGenero",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reservas",
                columns: table => new
                {
                    IdFilme = table.Column<long>(nullable: false),
                    IdLocacao = table.Column<long>(nullable: false),
                    ClienteModelIdCliente = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservas", x => new { x.IdFilme, x.IdLocacao });
                    table.ForeignKey(
                        name: "FK_Reservas_Clientes_ClienteModelIdCliente",
                        column: x => x.ClienteModelIdCliente,
                        principalTable: "Clientes",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reservas_Filmes_IdFilme",
                        column: x => x.IdFilme,
                        principalTable: "Filmes",
                        principalColumn: "IdFilme",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservas_Locacoes_IdLocacao",
                        column: x => x.IdLocacao,
                        principalTable: "Locacoes",
                        principalColumn: "IdLocacao",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Generos",
                columns: new[] { "IdGenero", "DataCriacao", "Descricao" },
                values: new object[,]
                {
                    { 1L, new DateTime(2022, 4, 18, 21, 56, 16, 606, DateTimeKind.Local).AddTicks(5672), "Terror" },
                    { 2L, new DateTime(2022, 4, 18, 21, 56, 16, 607, DateTimeKind.Local).AddTicks(5276), "Comedia" },
                    { 3L, new DateTime(2022, 4, 18, 21, 56, 16, 607, DateTimeKind.Local).AddTicks(5300), "Acao" },
                    { 4L, new DateTime(2022, 4, 18, 21, 56, 16, 607, DateTimeKind.Local).AddTicks(5303), "Drama" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "IdUsuario", "DataCriacao", "Login", "Nome", "Senha" },
                values: new object[] { 1L, new DateTime(2022, 4, 18, 21, 56, 16, 608, DateTimeKind.Local).AddTicks(9155), "admin@admin.com", "Administrador", "admin" });

            migrationBuilder.InsertData(
                table: "Filmes",
                columns: new[] { "IdFilme", "DataCriacao", "IdGenero", "Preco", "Titulo" },
                values: new object[] { 2L, new DateTime(2022, 4, 18, 21, 56, 16, 609, DateTimeKind.Local).AddTicks(6304), 2L, 19.989999999999998, "Space Jam: Um Novo Legado" });

            migrationBuilder.InsertData(
                table: "Filmes",
                columns: new[] { "IdFilme", "DataCriacao", "IdGenero", "Preco", "Titulo" },
                values: new object[] { 1L, new DateTime(2022, 4, 18, 21, 56, 16, 609, DateTimeKind.Local).AddTicks(5839), 3L, 14.99, "Viuva Negra" });

            migrationBuilder.CreateIndex(
                name: "IX_Filmes_IdGenero",
                table: "Filmes",
                column: "IdGenero");

            migrationBuilder.CreateIndex(
                name: "IX_Locacoes_IdCliente",
                table: "Locacoes",
                column: "IdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_ClienteModelIdCliente",
                table: "Reservas",
                column: "ClienteModelIdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_IdLocacao",
                table: "Reservas",
                column: "IdLocacao");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservas");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Filmes");

            migrationBuilder.DropTable(
                name: "Locacoes");

            migrationBuilder.DropTable(
                name: "Generos");

            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
