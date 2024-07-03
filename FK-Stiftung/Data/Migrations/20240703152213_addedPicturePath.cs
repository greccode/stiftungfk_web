using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FK_Stiftung.Data.Migrations
{
    /// <inheritdoc />
    public partial class addedPicturePath : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PicturePath",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "PicturePath",
                value: "https://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=205119&type=card");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                column: "PicturePath",
                value: "https://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=205119&type=card");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                column: "PicturePath",
                value: "https://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=205119&type=card");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PicturePath",
                table: "Projects");
        }
    }
}
