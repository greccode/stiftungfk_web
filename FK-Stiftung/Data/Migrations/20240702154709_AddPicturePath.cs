using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FK_Stiftung.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddPicturePath : Migration
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
                value: "buch_offen_mit_schuber.jpg");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PicturePath",
                table: "Projects");
        }
    }
}
