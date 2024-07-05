using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FK_Stiftung.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddProjektFoerdererTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProjektFoerderer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjektFoerderer", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ProjektFoerderer",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Liam" },
                    { 2, "Leon" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjektFoerderer");
        }
    }
}
