using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PiecesOfArt.Migrations
{
    /// <inheritdoc />
    public partial class PieceOfArt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LoyaltyCards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoyaltyCards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    LoyaltyCardId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_LoyaltyCards_LoyaltyCardId",
                        column: x => x.LoyaltyCardId,
                        principalTable: "LoyaltyCards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PiecesOfArt",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PublicationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PiecesOfArt", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PiecesOfArt_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PiecesOfArt_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "A 19th-century art movement characterized by small, thin brush strokes and emphasis on light and movement.", "Impressionism" },
                    { 2, "A period in European history marking the revival of classical learning and wisdom.", "Renaissance" },
                    { 3, "Art that uses shapes, colors, forms, and gestural marks to achieve its effect rather than depicting objects.", "Abstract" },
                    { 4, "A broad category that reflects artistic work produced during the late 19th to mid-20th century.", "Modern" },
                    { 5, "Art from ancient civilizations, including Egyptian, Mesopotamian, and classical Greek.", "Ancient" }
                });

            migrationBuilder.InsertData(
                table: "LoyaltyCards",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "10% Off", "Bronze" },
                    { 2, "20% Off", "Silver" },
                    { 3, "30% Off", "Gold" },
                    { 4, "40% Off", "Platinum" },
                    { 5, "50% Off", "Crystal" }
                });

            migrationBuilder.InsertData(
                table: "PiecesOfArt",
                columns: new[] { "Id", "CategoryId", "Price", "PublicationDate", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, 1, 100000m, new DateTime(2024, 10, 26, 0, 28, 25, 306, DateTimeKind.Local).AddTicks(8631), "Starry Night", null },
                    { 2, 2, 500000m, new DateTime(2024, 10, 26, 0, 28, 25, 310, DateTimeKind.Local).AddTicks(5414), "The Mona Lisa", null },
                    { 3, 3, 120000m, new DateTime(2024, 10, 26, 0, 28, 25, 310, DateTimeKind.Local).AddTicks(5454), "Composition VIII", null },
                    { 4, 4, 200000m, new DateTime(2024, 10, 26, 0, 28, 25, 310, DateTimeKind.Local).AddTicks(5460), "The Persistence of Memory", null },
                    { 5, 5, 150000m, new DateTime(2024, 10, 26, 0, 28, 25, 310, DateTimeKind.Local).AddTicks(5463), "Small Pyramid", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "Email", "LoyaltyCardId", "Name" },
                values: new object[,]
                {
                    { 1, 30, "user1@example.com", 1, "User1" },
                    { 2, 25, "user2@example.com", 2, "User2" },
                    { 3, 28, "user3@example.com", 3, "User3" },
                    { 4, 22, "user4@example.com", 4, "User4" },
                    { 5, 26, "user5@example.com", 5, "User5" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PiecesOfArt_CategoryId",
                table: "PiecesOfArt",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_PiecesOfArt_UserId",
                table: "PiecesOfArt",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_LoyaltyCardId",
                table: "Users",
                column: "LoyaltyCardId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PiecesOfArt");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "LoyaltyCards");
        }
    }
}
