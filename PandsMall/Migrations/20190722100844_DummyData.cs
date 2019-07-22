using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PandsMall.Migrations
{
    public partial class DummyData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Products",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 7, 22, 11, 8, 42, 542, DateTimeKind.Local).AddTicks(416), new DateTime(2019, 7, 22, 11, 8, 42, 542, DateTimeKind.Local).AddTicks(430), "Toiletries" },
                    { 2, new DateTime(2019, 7, 22, 11, 8, 42, 542, DateTimeKind.Local).AddTicks(452), new DateTime(2019, 7, 22, 11, 8, 42, 542, DateTimeKind.Local).AddTicks(452), "Fruits" },
                    { 3, new DateTime(2019, 7, 22, 11, 8, 42, 542, DateTimeKind.Local).AddTicks(457), new DateTime(2019, 7, 22, 11, 8, 42, 542, DateTimeKind.Local).AddTicks(457), "Drinks" },
                    { 4, new DateTime(2019, 7, 22, 11, 8, 42, 542, DateTimeKind.Local).AddTicks(461), new DateTime(2019, 7, 22, 11, 8, 42, 542, DateTimeKind.Local).AddTicks(461), "Kitchen" },
                    { 5, new DateTime(2019, 7, 22, 11, 8, 42, 542, DateTimeKind.Local).AddTicks(461), new DateTime(2019, 7, 22, 11, 8, 42, 542, DateTimeKind.Local).AddTicks(466), "Bakeries" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateUpdated", "Name", "Price", "QuantityInPackage", "UnitOfMeasurement" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2019, 7, 22, 11, 8, 42, 509, DateTimeKind.Local).AddTicks(3588), new DateTime(2019, 7, 22, 11, 8, 42, 540, DateTimeKind.Local).AddTicks(2289), "Delta Soap", 750.0, (short)6, (byte)3 },
                    { 2, 2, new DateTime(2019, 7, 22, 11, 8, 42, 540, DateTimeKind.Local).AddTicks(3489), new DateTime(2019, 7, 22, 11, 8, 42, 540, DateTimeKind.Local).AddTicks(3503), "Apple", 500.0, (short)6, (byte)3 },
                    { 3, 3, new DateTime(2019, 7, 22, 11, 8, 42, 540, DateTimeKind.Local).AddTicks(3516), new DateTime(2019, 7, 22, 11, 8, 42, 540, DateTimeKind.Local).AddTicks(3521), "Pepsi", 1500.0, (short)12, (byte)5 },
                    { 4, 4, new DateTime(2019, 7, 22, 11, 8, 42, 540, DateTimeKind.Local).AddTicks(3521), new DateTime(2019, 7, 22, 11, 8, 42, 540, DateTimeKind.Local).AddTicks(3525), "Gas Cooker", 3000.0, (short)1, (byte)4 },
                    { 5, 5, new DateTime(2019, 7, 22, 11, 8, 42, 540, DateTimeKind.Local).AddTicks(3525), new DateTime(2019, 7, 22, 11, 8, 42, 540, DateTimeKind.Local).AddTicks(3530), "Meat Pie", 300.0, (short)1, (byte)3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Products");
        }
    }
}
