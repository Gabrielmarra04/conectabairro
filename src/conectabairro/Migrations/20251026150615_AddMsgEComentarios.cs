using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace conectabairro.Migrations
{
    /// <inheritdoc />
    public partial class AddMsgEComentarios : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Usuario_AutorId",
                table: "Posts");

            migrationBuilder.AlterColumn<string>(
                name: "PasswordHash",
                table: "Usuario",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "DislikesCount",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Comentarios",
                columns: table => new
                {
                    ComentarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostId = table.Column<int>(type: "int", nullable: false),
                    AutorUsuarioId = table.Column<int>(type: "int", nullable: false),
                    Conteudo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataEnvio = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comentarios", x => x.ComentarioId);
                    table.ForeignKey(
                        name: "FK_Comentarios_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "PostId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comentarios_Usuario_AutorUsuarioId",
                        column: x => x.AutorUsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Conversas",
                columns: table => new
                {
                    ConversaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostId = table.Column<int>(type: "int", nullable: false),
                    AutorPostId = table.Column<int>(type: "int", nullable: false),
                    InteressadoUsuarioId = table.Column<int>(type: "int", nullable: false),
                    DataInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UltimaAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conversas", x => x.ConversaId);
                    table.ForeignKey(
                        name: "FK_Conversas_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "PostId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Conversas_Usuario_AutorPostId",
                        column: x => x.AutorPostId,
                        principalTable: "Usuario",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Conversas_Usuario_InteressadoUsuarioId",
                        column: x => x.InteressadoUsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Mensagens",
                columns: table => new
                {
                    MensagemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConversaId = table.Column<int>(type: "int", nullable: false),
                    RemetenteUsuarioId = table.Column<int>(type: "int", nullable: false),
                    Conteudo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataEnvio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Lida = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mensagens", x => x.MensagemId);
                    table.ForeignKey(
                        name: "FK_Mensagens_Conversas_ConversaId",
                        column: x => x.ConversaId,
                        principalTable: "Conversas",
                        principalColumn: "ConversaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Mensagens_Usuario_RemetenteUsuarioId",
                        column: x => x.RemetenteUsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "UsuarioId",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$13$Ha0RaHOqA3HHACVhx1/kaur2ntL2.IWuQ90z6EFO71IWkzy3Ialgm");

            migrationBuilder.CreateIndex(
                name: "IX_Comentarios_AutorUsuarioId",
                table: "Comentarios",
                column: "AutorUsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Comentarios_PostId",
                table: "Comentarios",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Conversas_AutorPostId",
                table: "Conversas",
                column: "AutorPostId");

            migrationBuilder.CreateIndex(
                name: "IX_Conversas_InteressadoUsuarioId",
                table: "Conversas",
                column: "InteressadoUsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Conversas_PostId_AutorPostId_InteressadoUsuarioId",
                table: "Conversas",
                columns: new[] { "PostId", "AutorPostId", "InteressadoUsuarioId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Mensagens_ConversaId",
                table: "Mensagens",
                column: "ConversaId");

            migrationBuilder.CreateIndex(
                name: "IX_Mensagens_RemetenteUsuarioId",
                table: "Mensagens",
                column: "RemetenteUsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Usuario_AutorId",
                table: "Posts",
                column: "AutorId",
                principalTable: "Usuario",
                principalColumn: "UsuarioId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Usuario_AutorId",
                table: "Posts");

            migrationBuilder.DropTable(
                name: "Comentarios");

            migrationBuilder.DropTable(
                name: "Mensagens");

            migrationBuilder.DropTable(
                name: "Conversas");

            migrationBuilder.DropColumn(
                name: "DislikesCount",
                table: "Posts");

            migrationBuilder.AlterColumn<string>(
                name: "PasswordHash",
                table: "Usuario",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "UsuarioId",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$13$.r1KxR1wijnPOT1U99e4Q.kA18QCPeoVuThl5lFyn3Op.uopG4yuK");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Usuario_AutorId",
                table: "Posts",
                column: "AutorId",
                principalTable: "Usuario",
                principalColumn: "UsuarioId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
