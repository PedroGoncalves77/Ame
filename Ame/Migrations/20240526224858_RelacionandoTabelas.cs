using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ame.Migrations
{
    /// <inheritdoc />
    public partial class RelacionandoTabelas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FichaBebeTresMesesId",
                table: "SaudeDaCriancas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SaudeDaCriancas_FichaBebeTresMesesId",
                table: "SaudeDaCriancas",
                column: "FichaBebeTresMesesId");

            migrationBuilder.AddForeignKey(
                name: "FK_SaudeDaCriancas_FichaBebeTresMeses_FichaBebeTresMesesId",
                table: "SaudeDaCriancas",
                column: "FichaBebeTresMesesId",
                principalTable: "FichaBebeTresMeses",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SaudeDaCriancas_FichaBebeTresMeses_FichaBebeTresMesesId",
                table: "SaudeDaCriancas");

            migrationBuilder.DropIndex(
                name: "IX_SaudeDaCriancas_FichaBebeTresMesesId",
                table: "SaudeDaCriancas");

            migrationBuilder.DropColumn(
                name: "FichaBebeTresMesesId",
                table: "SaudeDaCriancas");
        }
    }
}
