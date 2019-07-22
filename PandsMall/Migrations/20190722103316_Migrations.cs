using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PandsMall.Migrations
{
    public partial class Migrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateUpdated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateUpdated = table.Column<DateTime>(nullable: false),
                    QuantityInPackage = table.Column<short>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 7, 22, 11, 33, 15, 419, DateTimeKind.Local).AddTicks(6778), new DateTime(2019, 7, 22, 11, 33, 15, 419, DateTimeKind.Local).AddTicks(6796), "Toiletries" },
                    { 2, new DateTime(2019, 7, 22, 11, 33, 15, 419, DateTimeKind.Local).AddTicks(6823), new DateTime(2019, 7, 22, 11, 33, 15, 419, DateTimeKind.Local).AddTicks(6828), "Fruits" },
                    { 3, new DateTime(2019, 7, 22, 11, 33, 15, 419, DateTimeKind.Local).AddTicks(6828), new DateTime(2019, 7, 22, 11, 33, 15, 419, DateTimeKind.Local).AddTicks(6833), "Drinks" },
                    { 4, new DateTime(2019, 7, 22, 11, 33, 15, 419, DateTimeKind.Local).AddTicks(6833), new DateTime(2019, 7, 22, 11, 33, 15, 419, DateTimeKind.Local).AddTicks(6833), "Kitchen" },
                    { 5, new DateTime(2019, 7, 22, 11, 33, 15, 419, DateTimeKind.Local).AddTicks(6837), new DateTime(2019, 7, 22, 11, 33, 15, 419, DateTimeKind.Local).AddTicks(6837), "Bakeries" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateUpdated", "Name", "Price", "QuantityInPackage" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2019, 7, 22, 11, 33, 15, 415, DateTimeKind.Local).AddTicks(4722), new DateTime(2019, 7, 22, 11, 33, 15, 417, DateTimeKind.Local).AddTicks(4992), "Delta Soap", 750.0, (short)6 },
                    { 2, 2, new DateTime(2019, 7, 22, 11, 33, 15, 417, DateTimeKind.Local).AddTicks(6346), new DateTime(2019, 7, 22, 11, 33, 15, 417, DateTimeKind.Local).AddTicks(6364), "Apple", 500.0, (short)6 },
                    { 3, 3, new DateTime(2019, 7, 22, 11, 33, 15, 417, DateTimeKind.Local).AddTicks(6378), new DateTime(2019, 7, 22, 11, 33, 15, 417, DateTimeKind.Local).AddTicks(6378), "Pepsi", 1500.0, (short)12 },
                    { 4, 4, new DateTime(2019, 7, 22, 11, 33, 15, 417, DateTimeKind.Local).AddTicks(6382), new DateTime(2019, 7, 22, 11, 33, 15, 417, DateTimeKind.Local).AddTicks(6382), "Gas Cooker", 3000.0, (short)1 },
                    { 5, 5, new DateTime(2019, 7, 22, 11, 33, 15, 417, DateTimeKind.Local).AddTicks(6387), new DateTime(2019, 7, 22, 11, 33, 15, 417, DateTimeKind.Local).AddTicks(6387), "Meat Pie", 300.0, (short)1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
