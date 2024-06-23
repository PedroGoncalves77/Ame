using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ame.Migrations
{
    /// <inheritdoc />
    public partial class AddProblemaSono : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProblemaSono",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FichaBebeTresMesesId = table.Column<int>(type: "int", nullable: true),
                    Pergunta60 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta61 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta61a = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta62 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta63 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta64 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta65 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta66 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta67 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta68 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta69 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta70 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta71 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta72 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta73 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProblemaSono", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProblemaSono_FichaBebeTresMeses_FichaBebeTresMesesId",
                        column: x => x.FichaBebeTresMesesId,
                        principalTable: "FichaBebeTresMeses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProblemaSono_FichaBebeTresMesesId",
                table: "ProblemaSono",
                column: "FichaBebeTresMesesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProblemaSono");
        }
    }
}
