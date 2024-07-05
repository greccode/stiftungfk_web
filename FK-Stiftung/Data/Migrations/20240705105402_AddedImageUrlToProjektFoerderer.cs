﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FK_Stiftung.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedImageUrlToProjektFoerderer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProjektFoerderer",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProjektFoerderer",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "ProjektFoerderer",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "ProjektFoerderer");

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Description", "Name", "PicturePath" },
                values: new object[,]
                {
                    { 1, "Das KI-Projekt ist super!", "KI-Projekt", "https://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=205119&type=card" },
                    { 2, "Mehr über unser Projekt: Europawoche.", "Europawoche", "https://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=205119&type=card" },
                    { 3, "Unser bisher wichtigstes Projekt.", "Liam nerven", "https://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=205119&type=card" }
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
    }
}
