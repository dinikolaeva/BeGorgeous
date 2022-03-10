using Microsoft.EntityFrameworkCore.Migrations;

namespace BeGorgeous.Data.Migrations
{
    public partial class AddNewPropertiesInStylistsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Stylists",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ShortAutobiography",
                table: "Stylists",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Stylists");

            migrationBuilder.DropColumn(
                name: "ShortAutobiography",
                table: "Stylists");
        }
    }
}
