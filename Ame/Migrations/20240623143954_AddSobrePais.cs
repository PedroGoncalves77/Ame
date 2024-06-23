using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ame.Migrations
{
    /// <inheritdoc />
    public partial class AddSobrePais : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SobrePais",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FichaBebeTresMesesId = table.Column<int>(type: "int", nullable: true),
                    Pergunta34 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta35 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta36 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta37 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta38 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta39 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta40 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta40v1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta41 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta42 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SobrePais", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SobrePais_FichaBebeTresMeses_FichaBebeTresMesesId",
                        column: x => x.FichaBebeTresMesesId,
                        principalTable: "FichaBebeTresMeses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TemperamentoCrianca",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FichaBebeTresMesesId = table.Column<int>(type: "int", nullable: true),
                    Pergunta31 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta32 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pergunta33 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TemperamentoCrianca", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TemperamentoCrianca_FichaBebeTresMeses_FichaBebeTresMesesId",
                        column: x => x.FichaBebeTresMesesId,
                        principalTable: "FichaBebeTresMeses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_SobrePais_FichaBebeTresMesesId",
                table: "SobrePais",
                column: "FichaBebeTresMesesId");

            migrationBuilder.CreateIndex(
                name: "IX_TemperamentoCrianca_FichaBebeTresMesesId",
                table: "TemperamentoCrianca",
                column: "FichaBebeTresMesesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SobrePais");

            migrationBuilder.DropTable(
                name: "TemperamentoCrianca");
        }
    }
}
