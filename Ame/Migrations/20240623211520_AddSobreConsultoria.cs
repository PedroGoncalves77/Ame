using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ame.Migrations
{
    /// <inheritdoc />
    public partial class AddSobreConsultoria : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SobreConsultoria",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FichaBebeTresMesesId = table.Column<int>(type: "int", nullable: true),
                    Pergunta90 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta91 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta92 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SobreConsultoria", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SobreConsultoria_FichaBebeTresMeses_FichaBebeTresMesesId",
                        column: x => x.FichaBebeTresMesesId,
                        principalTable: "FichaBebeTresMeses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_SobreConsultoria_FichaBebeTresMesesId",
                table: "SobreConsultoria",
                column: "FichaBebeTresMesesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SobreConsultoria");
        }
    }
}
