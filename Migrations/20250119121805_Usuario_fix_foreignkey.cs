using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoviesApi.Migrations
{
    /// <inheritdoc />
    public partial class Usuario_fix_foreignkey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_TB_USUARIO_FILME_IdUsuario",
                table: "TB_USUARIO_FILME");

            migrationBuilder.CreateIndex(
                name: "IX_TB_USUARIO_FILME_IdUsuario",
                table: "TB_USUARIO_FILME",
                column: "IdUsuario");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_TB_USUARIO_FILME_IdUsuario",
                table: "TB_USUARIO_FILME");

            migrationBuilder.CreateIndex(
                name: "IX_TB_USUARIO_FILME_IdUsuario",
                table: "TB_USUARIO_FILME",
                column: "IdUsuario",
                unique: true);
        }
    }
}
