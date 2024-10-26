using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PiecesOfArt.Migrations
{
    /// <inheritdoc />
    public partial class s : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PiecesOfArt",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublicationDate",
                value: new DateTime(2024, 10, 26, 14, 5, 54, 125, DateTimeKind.Local).AddTicks(4526));

            migrationBuilder.UpdateData(
                table: "PiecesOfArt",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublicationDate",
                value: new DateTime(2024, 10, 26, 14, 5, 54, 127, DateTimeKind.Local).AddTicks(6871));

            migrationBuilder.UpdateData(
                table: "PiecesOfArt",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublicationDate",
                value: new DateTime(2024, 10, 26, 14, 5, 54, 127, DateTimeKind.Local).AddTicks(6898));

            migrationBuilder.UpdateData(
                table: "PiecesOfArt",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublicationDate",
                value: new DateTime(2024, 10, 26, 14, 5, 54, 127, DateTimeKind.Local).AddTicks(6903));

            migrationBuilder.UpdateData(
                table: "PiecesOfArt",
                keyColumn: "Id",
                keyValue: 5,
                column: "PublicationDate",
                value: new DateTime(2024, 10, 26, 14, 5, 54, 127, DateTimeKind.Local).AddTicks(6905));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PiecesOfArt",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublicationDate",
                value: new DateTime(2024, 10, 26, 0, 28, 25, 306, DateTimeKind.Local).AddTicks(8631));

            migrationBuilder.UpdateData(
                table: "PiecesOfArt",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublicationDate",
                value: new DateTime(2024, 10, 26, 0, 28, 25, 310, DateTimeKind.Local).AddTicks(5414));

            migrationBuilder.UpdateData(
                table: "PiecesOfArt",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublicationDate",
                value: new DateTime(2024, 10, 26, 0, 28, 25, 310, DateTimeKind.Local).AddTicks(5454));

            migrationBuilder.UpdateData(
                table: "PiecesOfArt",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublicationDate",
                value: new DateTime(2024, 10, 26, 0, 28, 25, 310, DateTimeKind.Local).AddTicks(5460));

            migrationBuilder.UpdateData(
                table: "PiecesOfArt",
                keyColumn: "Id",
                keyValue: 5,
                column: "PublicationDate",
                value: new DateTime(2024, 10, 26, 0, 28, 25, 310, DateTimeKind.Local).AddTicks(5463));
        }
    }
}
