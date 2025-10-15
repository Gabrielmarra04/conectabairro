using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace conectabairro.Migrations
{
    /// <inheritdoc />
    public partial class AddResetTokenFieldsToUsuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ResetToken",
                table: "Usuario",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ResetTokenExpiry",
                table: "Usuario",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "UsuarioId",
                keyValue: 1,
                columns: new[] { "PasswordHash", "ResetToken", "ResetTokenExpiry" },
                values: new object[] { "$2a$13$8eV09/7yAsbTTXWKkGhdk.5cHAy7FH3A00nNNnINVRZrPVI6NZWOq", null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ResetToken",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "ResetTokenExpiry",
                table: "Usuario");

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "UsuarioId",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$13$r.u.iDaCwIuSOoKwV9bSEu1nCXqMlk.1.CGLWA8kTi.L08U9EWjk6");
        }
    }
}
