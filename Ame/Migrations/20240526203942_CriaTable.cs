using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ame.Migrations
{
    /// <inheritdoc />
    public partial class CriaTable : Migration
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FichaBebeTresMeses");
        }
    }
}
