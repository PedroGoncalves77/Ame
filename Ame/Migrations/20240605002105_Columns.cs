using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ame.Migrations
{
    /// <inheritdoc />
    public partial class Columns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FichaBebeTresMeses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Contrato = table.Column<int>(type: "int", nullable: false),
                    Data = table.Column<DateTime>(type: "date", nullable: false),
                    Nome_Mae = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Profissao_Mae = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nome_Pai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Profissao_Pai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Endereco = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nome_Crianca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Idade_Crianca = table.Column<double>(type: "float", nullable: false),
                    Data_Nascimento = table.Column<DateTime>(type: "date", nullable: false),
                    Nome_Pediatra = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FichaBebeTresMeses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NivelDeAtividade",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FichaBebeTresMesesId = table.Column<int>(type: "int", nullable: true),
                    Pergunta14 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta15 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta16 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta17 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta18 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta19 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NivelDeAtividade", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NivelDeAtividade_FichaBebeTresMeses_FichaBebeTresMesesId",
                        column: x => x.FichaBebeTresMesesId,
                        principalTable: "FichaBebeTresMeses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SaudeDaCriancas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FichaBebeTresMesesId = table.Column<int>(type: "int", nullable: true),
                    Pergunta1 = table.Column<DateTime>(type: "date", nullable: true),
                    Pergunta2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta8 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta9 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta10 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta11 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta12 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta13 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaudeDaCriancas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SaudeDaCriancas_FichaBebeTresMeses_FichaBebeTresMesesId",
                        column: x => x.FichaBebeTresMesesId,
                        principalTable: "FichaBebeTresMeses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_NivelDeAtividade_FichaBebeTresMesesId",
                table: "NivelDeAtividade",
                column: "FichaBebeTresMesesId");

            migrationBuilder.CreateIndex(
                name: "IX_SaudeDaCriancas_FichaBebeTresMesesId",
                table: "SaudeDaCriancas",
                column: "FichaBebeTresMesesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NivelDeAtividade");

            migrationBuilder.DropTable(
                name: "SaudeDaCriancas");

            migrationBuilder.DropTable(
                name: "FichaBebeTresMeses");
        }
    }
}
