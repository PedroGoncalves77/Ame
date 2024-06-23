using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ame.Migrations
{
    /// <inheritdoc />
    public partial class AddAmbienteSono : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AmbienteSono",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FichaBebeTresMesesId = table.Column<int>(type: "int", nullable: true),
                    Pergunta74 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta75 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta76 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta77 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta78 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta79 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta80 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta81 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta82 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta83 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta84 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta85 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta86 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta87 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta88 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta89a = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta89b = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AmbienteSono", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AmbienteSono_FichaBebeTresMeses_FichaBebeTresMesesId",
                        column: x => x.FichaBebeTresMesesId,
                        principalTable: "FichaBebeTresMeses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AmbienteSono_FichaBebeTresMesesId",
                table: "AmbienteSono",
                column: "FichaBebeTresMesesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AmbienteSono");
        }
    }
}
