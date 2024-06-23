using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ame.Migrations
{
    /// <inheritdoc />
    public partial class AddDinamicafamiliar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Pergunta35v1",
                table: "SobrePais",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DinamicaFamiliar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FichaBebeTresMesesId = table.Column<int>(type: "int", nullable: true),
                    Pergunta43 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta44 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta45 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta46 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta47 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta47a = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta47b = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta48 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta49 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta50 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta51 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta52 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta53 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta54 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta55 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta56 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta57 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta58 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta59 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DinamicaFamiliar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DinamicaFamiliar_FichaBebeTresMeses_FichaBebeTresMesesId",
                        column: x => x.FichaBebeTresMesesId,
                        principalTable: "FichaBebeTresMeses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_DinamicaFamiliar_FichaBebeTresMesesId",
                table: "DinamicaFamiliar",
                column: "FichaBebeTresMesesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DinamicaFamiliar");

            migrationBuilder.DropColumn(
                name: "Pergunta35v1",
                table: "SobrePais");
        }
    }
}
