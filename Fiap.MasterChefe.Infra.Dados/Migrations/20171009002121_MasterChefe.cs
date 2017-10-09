using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Fiap.MasterChefe.Infra.Dados.Migrations
{
    public partial class MasterChefe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoriaReceita",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExibirTelaPrincipal = table.Column<bool>(type: "bit", nullable: false),
                    UrlImagem = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriaReceita", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Receita",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoriaReceitaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rendimento = table.Column<int>(type: "int", nullable: false),
                    TempodePreparo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receita", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Receita_CategoriaReceita_CategoriaReceitaId",
                        column: x => x.CategoriaReceitaId,
                        principalTable: "CategoriaReceita",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ingrediente",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReceitaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingrediente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ingrediente_Receita_ReceitaId",
                        column: x => x.ReceitaId,
                        principalTable: "Receita",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ModoDePreparo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ordem = table.Column<short>(type: "smallint", nullable: false),
                    ReceitaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModoDePreparo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ModoDePreparo_Receita_ReceitaId",
                        column: x => x.ReceitaId,
                        principalTable: "Receita",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ingrediente_ReceitaId",
                table: "Ingrediente",
                column: "ReceitaId");

            migrationBuilder.CreateIndex(
                name: "IX_ModoDePreparo_ReceitaId",
                table: "ModoDePreparo",
                column: "ReceitaId");

            migrationBuilder.CreateIndex(
                name: "IX_Receita_CategoriaReceitaId",
                table: "Receita",
                column: "CategoriaReceitaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ingrediente");

            migrationBuilder.DropTable(
                name: "ModoDePreparo");

            migrationBuilder.DropTable(
                name: "Receita");

            migrationBuilder.DropTable(
                name: "CategoriaReceita");
        }
    }
}
