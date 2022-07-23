using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Locadora.WebApp.Infrastructure.Migrations
{
    public partial class migrtion2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Filmes",
                keyColumn: "IdFilme",
                keyValue: 1L,
                column: "DataCriacao",
                value: new DateTime(2022, 7, 5, 15, 50, 22, 724, DateTimeKind.Local).AddTicks(5919));

            migrationBuilder.UpdateData(
                table: "Filmes",
                keyColumn: "IdFilme",
                keyValue: 2L,
                column: "DataCriacao",
                value: new DateTime(2022, 7, 5, 15, 50, 22, 724, DateTimeKind.Local).AddTicks(6393));

            migrationBuilder.UpdateData(
                table: "Generos",
                keyColumn: "IdGenero",
                keyValue: 1L,
                column: "DataCriacao",
                value: new DateTime(2022, 7, 5, 15, 50, 22, 721, DateTimeKind.Local).AddTicks(4917));

            migrationBuilder.UpdateData(
                table: "Generos",
                keyColumn: "IdGenero",
                keyValue: 2L,
                column: "DataCriacao",
                value: new DateTime(2022, 7, 5, 15, 50, 22, 722, DateTimeKind.Local).AddTicks(8387));

            migrationBuilder.UpdateData(
                table: "Generos",
                keyColumn: "IdGenero",
                keyValue: 3L,
                column: "DataCriacao",
                value: new DateTime(2022, 7, 5, 15, 50, 22, 722, DateTimeKind.Local).AddTicks(8423));

            migrationBuilder.UpdateData(
                table: "Generos",
                keyColumn: "IdGenero",
                keyValue: 4L,
                column: "DataCriacao",
                value: new DateTime(2022, 7, 5, 15, 50, 22, 722, DateTimeKind.Local).AddTicks(8427));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "IdUsuario",
                keyValue: 1L,
                column: "DataCriacao",
                value: new DateTime(2022, 7, 5, 15, 50, 22, 724, DateTimeKind.Local).AddTicks(2884));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Filmes",
                keyColumn: "IdFilme",
                keyValue: 1L,
                column: "DataCriacao",
                value: new DateTime(2022, 4, 18, 21, 56, 16, 609, DateTimeKind.Local).AddTicks(5839));

            migrationBuilder.UpdateData(
                table: "Filmes",
                keyColumn: "IdFilme",
                keyValue: 2L,
                column: "DataCriacao",
                value: new DateTime(2022, 4, 18, 21, 56, 16, 609, DateTimeKind.Local).AddTicks(6304));

            migrationBuilder.UpdateData(
                table: "Generos",
                keyColumn: "IdGenero",
                keyValue: 1L,
                column: "DataCriacao",
                value: new DateTime(2022, 4, 18, 21, 56, 16, 606, DateTimeKind.Local).AddTicks(5672));

            migrationBuilder.UpdateData(
                table: "Generos",
                keyColumn: "IdGenero",
                keyValue: 2L,
                column: "DataCriacao",
                value: new DateTime(2022, 4, 18, 21, 56, 16, 607, DateTimeKind.Local).AddTicks(5276));

            migrationBuilder.UpdateData(
                table: "Generos",
                keyColumn: "IdGenero",
                keyValue: 3L,
                column: "DataCriacao",
                value: new DateTime(2022, 4, 18, 21, 56, 16, 607, DateTimeKind.Local).AddTicks(5300));

            migrationBuilder.UpdateData(
                table: "Generos",
                keyColumn: "IdGenero",
                keyValue: 4L,
                column: "DataCriacao",
                value: new DateTime(2022, 4, 18, 21, 56, 16, 607, DateTimeKind.Local).AddTicks(5303));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "IdUsuario",
                keyValue: 1L,
                column: "DataCriacao",
                value: new DateTime(2022, 4, 18, 21, 56, 16, 608, DateTimeKind.Local).AddTicks(9155));
        }
    }
}
