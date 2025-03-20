using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventoPlus.Migrations
{
    /// <inheritdoc />
    public partial class Db_EventPlusv2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Situacao",
                table: "Presenca",
                type: "BIT",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "Exibe",
                table: "ComentarioEvento",
                type: "BIT",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Situacao",
                table: "Presenca",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "BIT");

            migrationBuilder.AlterColumn<bool>(
                name: "Exibe",
                table: "ComentarioEvento",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "BIT");
        }
    }
}
