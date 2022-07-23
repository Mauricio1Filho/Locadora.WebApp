using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Locadora.WebApp.Infrastructure.Migrations
{
    public partial class migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    IdCliente = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Cpf = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.IdCliente);
                });

            migrationBuilder.CreateTable(
                name: "Generos",
                columns: table => new
                {
                    IdGenero = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Generos", x => x.IdGenero);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    IdUsuario = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Login = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.IdUsuario);
                });

            migrationBuilder.CreateTable(
                name: "Locacoes",
                columns: table => new
                {
                    IdLocacao = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCliente = table.Column<long>(type: "bigint", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                    IdFilme = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IdGenero = table.Column<long>(type: "bigint", nullable: false),
                    Preco = table.Column<double>(type: "float", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                    IdFilme = table.Column<long>(type: "bigint", nullable: false),
                    IdCliente = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservas", x => new { x.IdFilme, x.IdCliente });
                    table.ForeignKey(
                        name: "FK_Reservas_Clientes_IdCliente",
                        column: x => x.IdCliente,
                        principalTable: "Clientes",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservas_Filmes_IdFilme",
                        column: x => x.IdFilme,
                        principalTable: "Filmes",
                        principalColumn: "IdFilme",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Generos",
                columns: new[] { "IdGenero", "DataCriacao", "Descricao" },
                values: new object[,]
                {
                    { 1L, new DateTime(2021, 7, 22, 4, 9, 25, 644, DateTimeKind.Local).AddTicks(5071), "Terror" },
                    { 2L, new DateTime(2021, 7, 22, 4, 9, 25, 645, DateTimeKind.Local).AddTicks(8390), "Comedia" },
                    { 3L, new DateTime(2021, 7, 22, 4, 9, 25, 645, DateTimeKind.Local).AddTicks(8418), "Acao" },
                    { 4L, new DateTime(2021, 7, 22, 4, 9, 25, 645, DateTimeKind.Local).AddTicks(8421), "Drama" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "IdUsuario", "DataCriacao", "Login", "Nome", "Senha" },
                values: new object[] { 1L, new DateTime(2021, 7, 22, 4, 9, 25, 647, DateTimeKind.Local).AddTicks(4187), "admin@admin.com", "Administrador", "admin" });

            migrationBuilder.InsertData(
                table: "Filmes",
                columns: new[] { "IdFilme", "DataCriacao", "IdGenero", "Preco", "Titulo" },
                values: new object[] { 2L, new DateTime(2021, 7, 22, 4, 9, 25, 647, DateTimeKind.Local).AddTicks(8648), 2L, 19.989999999999998, "Space Jam: Um Novo Legado" });

            migrationBuilder.InsertData(
                table: "Filmes",
                columns: new[] { "IdFilme", "DataCriacao", "IdGenero", "Preco", "Titulo" },
                values: new object[] { 1L, new DateTime(2021, 7, 22, 4, 9, 25, 647, DateTimeKind.Local).AddTicks(7803), 3L, 14.99, "Viuva Negra" });

            migrationBuilder.CreateIndex(
                name: "IX_Filmes_IdGenero",
                table: "Filmes",
                column: "IdGenero");

            migrationBuilder.CreateIndex(
                name: "IX_Locacoes_IdCliente",
                table: "Locacoes",
                column: "IdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_IdCliente",
                table: "Reservas",
                column: "IdCliente");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Locacoes");

            migrationBuilder.DropTable(
                name: "Reservas");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Filmes");

            migrationBuilder.DropTable(
                name: "Generos");
        }
    }
}
