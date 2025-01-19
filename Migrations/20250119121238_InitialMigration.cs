using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoviesApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_FILMES",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Ano_Lancamento = table.Column<int>(type: "int", nullable: false),
                    Diretor = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Status = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Likes = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    Dislikes = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_FILMES", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_USUARIOS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Jwt = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_USUARIOS", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_USUARIO_FILME",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdUsuario = table.Column<int>(type: "int", nullable: false),
                    IdFilme = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_USUARIO_FILME", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TB_USUARIO_FILME_TB_USUARIOS_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "TB_USUARIOS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_FILMES_Nome",
                table: "TB_FILMES",
                column: "Nome",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TB_USUARIO_FILME_IdUsuario",
                table: "TB_USUARIO_FILME",
                column: "IdUsuario",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TB_USUARIOS_Email",
                table: "TB_USUARIOS",
                column: "Email",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_FILMES");

            migrationBuilder.DropTable(
                name: "TB_USUARIO_FILME");

            migrationBuilder.DropTable(
                name: "TB_USUARIOS");
        }
    }
}
