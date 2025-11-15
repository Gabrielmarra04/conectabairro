using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace conectabairro.Migrations
{
    /// <inheritdoc />
    public partial class teste : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Reacao_PostId",
                table: "Reacao");

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "UsuarioId",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$13$qWvN8ZENXpEfrl6N9Mv34.V91a68hEXuqodm8q9WhQUh8lJFjKIcu");

            migrationBuilder.CreateIndex(
                name: "IX_Reacao_PostId_AutorUsuarioId",
                table: "Reacao",
                columns: new[] { "PostId", "AutorUsuarioId" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Reacao_PostId_AutorUsuarioId",
                table: "Reacao");

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "UsuarioId",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$13$shwrzAdaQXuYGGfolQlWI.avL5M/TIEDl/3oGiXVG.d6V7DFlBaci");

            migrationBuilder.CreateIndex(
                name: "IX_Reacao_PostId",
                table: "Reacao",
                column: "PostId");
        }
    }
}
