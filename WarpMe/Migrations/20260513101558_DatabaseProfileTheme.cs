using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WarpMe.Migrations
{
    /// <inheritdoc />
    public partial class DatabaseProfileTheme : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccentColor",
                table: "LinkItems");

            migrationBuilder.DropColumn(
                name: "BackgroundColor",
                table: "LinkItems");

            migrationBuilder.CreateTable(
                name: "ProfileThemes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProfileId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProfileWallpaper = table.Column<string>(type: "TEXT", nullable: false),
                    ProfileNameColor = table.Column<string>(type: "TEXT", nullable: false),
                    ProfileFontFamily = table.Column<string>(type: "TEXT", nullable: false),
                    ProfileButtonStyle = table.Column<string>(type: "TEXT", nullable: false),
                    ProfileButtonCorner = table.Column<string>(type: "TEXT", nullable: false),
                    ProfileButtonAccentColor = table.Column<string>(type: "TEXT", nullable: false),
                    ProfileButtonBackgroundColor = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfileThemes", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProfileThemes");

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
    }
}
