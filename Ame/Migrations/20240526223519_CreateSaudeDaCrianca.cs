using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ame.Migrations
{
    /// <inheritdoc />
    public partial class CreateSaudeDaCrianca : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SaudeDaCriancas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pergunta1 = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Pergunta2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pergunta3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pergunta4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pergunta5 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pergunta6 = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SaudeDaCriancas");
        }
    }
}
