using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Locadora.WebApp.Infrastructure.Migrations
{
    public partial class model : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contatos",
                columns: table => new
                {
                    IdContato = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(nullable: false),
                    Celular = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contatos", x => x.IdContato);
                });

            migrationBuilder.CreateTable(
                name: "Enderecos",
                columns: table => new
                {
                    IdEndereco = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Endereco = table.Column<string>(nullable: false),
                    Numero = table.Column<int>(nullable: false),
                    Bairro = table.Column<string>(nullable: false),
                    CEP = table.Column<string>(nullable: false),
                    Cidade = table.Column<string>(nullable: false),
                    Estado = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enderecos", x => x.IdEndereco);
                });

            migrationBuilder.CreateTable(
                name: "Generos",
                columns: table => new
                {
                    IdGenero = table.Column<int>(nullable: false)
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
                    IdUsuario = table.Column<int>(nullable: false)
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
                name: "Clientes",
                columns: table => new
                {
                    IdCliente = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ClienteIdContato = table.Column<int>(nullable: false),
                    ClienteIdEndereco = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(nullable: false),
                    Cpf = table.Column<string>(nullable: false),
                    Sexo = table.Column<string>(nullable: false),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    DataNascimento = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.IdCliente);
                    table.ForeignKey(
                        name: "FK_Clientes_Contatos_ClienteIdContato",
                        column: x => x.ClienteIdContato,
                        principalTable: "Contatos",
                        principalColumn: "IdContato",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Clientes_Enderecos_ClienteIdEndereco",
                        column: x => x.ClienteIdEndereco,
                        principalTable: "Enderecos",
                        principalColumn: "IdEndereco",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Filmes",
                columns: table => new
                {
                    IdFilme = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FilmeIdGenero = table.Column<int>(nullable: false),
                    Titulo = table.Column<string>(maxLength: 50, nullable: false),
                    DataCriacao = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filmes", x => x.IdFilme);
                    table.ForeignKey(
                        name: "FK_Filmes_Generos_FilmeIdGenero",
                        column: x => x.FilmeIdGenero,
                        principalTable: "Generos",
                        principalColumn: "IdGenero",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Locacoes",
                columns: table => new
                {
                    IdLocacao = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ClienteIdCliente = table.Column<int>(nullable: false),
                    DataCriacao = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locacoes", x => x.IdLocacao);
                    table.ForeignKey(
                        name: "FK_Locacoes_Clientes_ClienteIdCliente",
                        column: x => x.ClienteIdCliente,
                        principalTable: "Clientes",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LocacaoFilmes",
                columns: table => new
                {
                    FilmeId = table.Column<int>(nullable: false),
                    LocacaoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocacaoFilmes", x => new { x.LocacaoId, x.FilmeId });
                    table.ForeignKey(
                        name: "FK_LocacaoFilmes_Filmes_FilmeId",
                        column: x => x.FilmeId,
                        principalTable: "Filmes",
                        principalColumn: "IdFilme",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LocacaoFilmes_Locacoes_LocacaoId",
                        column: x => x.LocacaoId,
                        principalTable: "Locacoes",
                        principalColumn: "IdLocacao",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Generos",
                columns: new[] { "IdGenero", "DataCriacao", "Descricao" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 9, 11, 21, 52, 54, 61, DateTimeKind.Local).AddTicks(1414), "Terror" },
                    { 2, new DateTime(2022, 9, 11, 21, 52, 54, 61, DateTimeKind.Local).AddTicks(1911), "Ação" },
                    { 3, new DateTime(2022, 9, 11, 21, 52, 54, 61, DateTimeKind.Local).AddTicks(1926), "Drama" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "IdUsuario", "DataCriacao", "Login", "Nome", "Senha" },
                values: new object[] { 1, new DateTime(2022, 9, 11, 21, 52, 54, 57, DateTimeKind.Local).AddTicks(7276), "admin@admin.com", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "Filmes",
                columns: new[] { "IdFilme", "DataCriacao", "FilmeIdGenero", "Titulo" },
                values: new object[] { 1, new DateTime(2022, 9, 11, 21, 52, 54, 62, DateTimeKind.Local).AddTicks(2450), 1, "IT: A Coisa" });

            migrationBuilder.InsertData(
                table: "Filmes",
                columns: new[] { "IdFilme", "DataCriacao", "FilmeIdGenero", "Titulo" },
                values: new object[] { 2, new DateTime(2022, 9, 11, 21, 52, 54, 62, DateTimeKind.Local).AddTicks(2910), 2, "John Wick 3: Parabellum" });

            migrationBuilder.InsertData(
                table: "Filmes",
                columns: new[] { "IdFilme", "DataCriacao", "FilmeIdGenero", "Titulo" },
                values: new object[] { 3, new DateTime(2022, 9, 11, 21, 52, 54, 62, DateTimeKind.Local).AddTicks(2933), 3, "O Homem do Norte" });

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_ClienteIdContato",
                table: "Clientes",
                column: "ClienteIdContato",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_ClienteIdEndereco",
                table: "Clientes",
                column: "ClienteIdEndereco",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Filmes_FilmeIdGenero",
                table: "Filmes",
                column: "FilmeIdGenero");

            migrationBuilder.CreateIndex(
                name: "IX_LocacaoFilmes_FilmeId",
                table: "LocacaoFilmes",
                column: "FilmeId");

            migrationBuilder.CreateIndex(
                name: "IX_Locacoes_ClienteIdCliente",
                table: "Locacoes",
                column: "ClienteIdCliente");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LocacaoFilmes");

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

            migrationBuilder.DropTable(
                name: "Contatos");

            migrationBuilder.DropTable(
                name: "Enderecos");
        }
    }
}
