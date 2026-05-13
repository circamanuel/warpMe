using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WarpMe.Migrations
{
    /// <inheritdoc />
    public partial class AddIconToTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Icon",
                table: "LinkItems",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Icon",
                table: "LinkItems");
        }
    }
}
