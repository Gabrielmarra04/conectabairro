using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace conectabairro.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarSolicitacoes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SolicitacoesEdicao",
                columns: table => new
                {
                    SolicitacaoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    NovaRua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NovoBairro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NovaCidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NovoEstado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataSolicitacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolicitacoesEdicao", x => x.SolicitacaoId);
                    table.ForeignKey(
                        name: "FK_SolicitacoesEdicao_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "UsuarioId",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$13$Gn3F7qkrzVWosndLaiRD6OzWWZrWfjCFNzTI2R4/6FAwy2BV2ZkTu");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitacoesEdicao_UsuarioId",
                table: "SolicitacoesEdicao",
                column: "UsuarioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SolicitacoesEdicao");

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "UsuarioId",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$13$qWvN8ZENXpEfrl6N9Mv34.V91a68hEXuqodm8q9WhQUh8lJFjKIcu");
        }
    }
}
