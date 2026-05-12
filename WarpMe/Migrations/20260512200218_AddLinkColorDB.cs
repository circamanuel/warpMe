using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WarpMe.Migrations
{
    /// <inheritdoc />
    public partial class AddLinkColorDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AccentColor",
                table: "LinkItems",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BackgroundColor",
                table: "LinkItems",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccentColor",
                table: "LinkItems");

            migrationBuilder.DropColumn(
                name: "BackgroundColor",
                table: "LinkItems");
        }
    }
}
