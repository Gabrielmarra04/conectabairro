using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace conectabairro.Migrations
{
    /// <inheritdoc />
    public partial class AddNotificacaoTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "UsuarioId",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$13$ZTcMO7gOMe9PDCO1kGAhI.BenYhERgqZElUU41AorjFFVq53dsaIK");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "UsuarioId",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$13$eARnFlVAG5g/Kpw.J2yk6.TkH6VdJq.30q4MiOvuGZlotoAwNoFYi");
        }
    }
}
