using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace conectabairro.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarTabelaReacoes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reacao",
                columns: table => new
                {
                    ReacaoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostId = table.Column<int>(type: "int", nullable: false),
                    AutorUsuarioId = table.Column<int>(type: "int", nullable: false),
                    TipoReacao = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reacao", x => x.ReacaoId);
                    table.ForeignKey(
                        name: "FK_Reacao_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "PostId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reacao_Usuario_AutorUsuarioId",
                        column: x => x.AutorUsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "UsuarioId",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$13$shwrzAdaQXuYGGfolQlWI.avL5M/TIEDl/3oGiXVG.d6V7DFlBaci");

            migrationBuilder.CreateIndex(
                name: "IX_Reacao_AutorUsuarioId",
                table: "Reacao",
                column: "AutorUsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Reacao_PostId",
                table: "Reacao",
                column: "PostId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reacao");

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "UsuarioId",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$13$Ha0RaHOqA3HHACVhx1/kaur2ntL2.IWuQ90z6EFO71IWkzy3Ialgm");
        }
    }
}
