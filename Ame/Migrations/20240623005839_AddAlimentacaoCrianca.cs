using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ame.Migrations
{
    /// <inheritdoc />
    public partial class AddAlimentacaoCrianca : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Pergunta20",
                table: "NivelDeAtividade",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Pergunta21",
                table: "NivelDeAtividade",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AlimentacaoCrianca",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FichaBebeTresMesesId = table.Column<int>(type: "int", nullable: true),
                    Pergunta22 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta23 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta24 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta25 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta26 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta27 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta28 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta29 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta30 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlimentacaoCrianca", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AlimentacaoCrianca_FichaBebeTresMeses_FichaBebeTresMesesId",
                        column: x => x.FichaBebeTresMesesId,
                        principalTable: "FichaBebeTresMeses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AlimentacaoCrianca_FichaBebeTresMesesId",
                table: "AlimentacaoCrianca",
                column: "FichaBebeTresMesesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlimentacaoCrianca");

            migrationBuilder.DropColumn(
                name: "Pergunta20",
                table: "NivelDeAtividade");

            migrationBuilder.DropColumn(
                name: "Pergunta21",
                table: "NivelDeAtividade");
        }
    }
}
