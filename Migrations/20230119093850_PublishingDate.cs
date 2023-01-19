using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProiectCioranuSorinGeorge.Migrations
{
    /// <inheritdoc />
    public partial class PublishingDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumarComanda",
                table: "Livrare",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumarContact",
                table: "Livrare",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Nume",
                table: "Livrare",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumarComanda",
                table: "Livrare");

            migrationBuilder.DropColumn(
                name: "NumarContact",
                table: "Livrare");

            migrationBuilder.DropColumn(
                name: "Nume",
                table: "Livrare");
        }
    }
}
