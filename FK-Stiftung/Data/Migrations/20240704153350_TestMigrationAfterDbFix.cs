using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FK_Stiftung.Data.Migrations
{
    /// <inheritdoc />
    public partial class TestMigrationAfterDbFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "PicturePath",
                value: "C:\\Users\\leono\\source\\repos\\FK-Stiftung\\FK-Stiftung\\wwwroot\\images\\buch_offen_mit_schuber.jpg");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                column: "PicturePath",
                value: "C:\\Users\\leono\\source\\repos\\FK-Stiftung\\FK-Stiftung\\wwwroot\\images\\buch_offen_mit_schuber.jpg");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                column: "PicturePath",
                value: "C:\\Users\\leono\\source\\repos\\FK-Stiftung\\FK-Stiftung\\wwwroot\\images\\buch_offen_mit_schuber.jpg");
        }
    }
}
