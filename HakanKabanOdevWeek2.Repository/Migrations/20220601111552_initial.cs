using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HakanKabanOdevWeek2.Repository.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    MembershipDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CountGame = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GamesName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DownloadCounts = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Games_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserGames",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    GamesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserGames", x => new { x.UserId, x.GamesId });
                    table.ForeignKey(
                        name: "FK_UserGames_Games_UserId",
                        column: x => x.UserId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserGames_Users_GamesId",
                        column: x => x.GamesId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Sport" },
                    { 2, "Fight" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CountGame", "MembershipDate", "UserName" },
                values: new object[,]
                {
                    { 1, 24, new DateTime(2022, 6, 1, 14, 15, 51, 766, DateTimeKind.Local).AddTicks(368), "Hakan" },
                    { 2, 34, new DateTime(2022, 6, 1, 14, 15, 51, 766, DateTimeKind.Local).AddTicks(379), "Hakan2" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "CategoryId", "DownloadCounts", "GamesName" },
                values: new object[] { 1, 1, 3000, "Pes2022" });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "CategoryId", "DownloadCounts", "GamesName" },
                values: new object[] { 2, 1, 4000, "Fifa2022" });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "CategoryId", "DownloadCounts", "GamesName" },
                values: new object[] { 3, 2, 3200, "Tekken8" });

            migrationBuilder.CreateIndex(
                name: "IX_Games_CategoryId",
                table: "Games",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_UserGames_GamesId",
                table: "UserGames",
                column: "GamesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserGames");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
