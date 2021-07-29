using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MigrationsPostgre.Migrations
{
    public partial class DataHoraCadastroDeFuncionarios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "nome",
                table: "funcionarios",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "idade",
                table: "funcionarios",
                newName: "Idade");

            migrationBuilder.RenameColumn(
                name: "funcao",
                table: "funcionarios",
                newName: "Funcao");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "funcionarios",
                newName: "Id");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataHoraCadastro",
                table: "funcionarios",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataHoraCadastro",
                table: "funcionarios");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "funcionarios",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Idade",
                table: "funcionarios",
                newName: "idade");

            migrationBuilder.RenameColumn(
                name: "Funcao",
                table: "funcionarios",
                newName: "funcao");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "funcionarios",
                newName: "id");
        }
    }
}
