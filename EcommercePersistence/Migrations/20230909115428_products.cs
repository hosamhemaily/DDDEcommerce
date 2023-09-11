using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcommercePersistence.Migrations
{
    /// <inheritdoc />
    public partial class products : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "CurrentQuantity",
                table: "Products",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("08ac377c-ba18-40ab-a496-a5286185036d"),
                columns: new[] { "CurrentQuantity", "ExpiryDate" },
                values: new object[] { 200m, new DateTime(2023, 9, 9, 14, 54, 28, 99, DateTimeKind.Local).AddTicks(8740) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cc4b3750-9b7d-4a43-9c99-045642717cca"),
                columns: new[] { "CurrentQuantity", "ExpiryDate" },
                values: new object[] { 100m, new DateTime(2023, 9, 9, 14, 54, 28, 99, DateTimeKind.Local).AddTicks(8848) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CurrentQuantity",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("08ac377c-ba18-40ab-a496-a5286185036d"),
                columns: new[] { "CurrentQuantity", "ExpiryDate" },
                values: new object[] { 200, new DateTime(2023, 3, 30, 10, 57, 10, 373, DateTimeKind.Local).AddTicks(783) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cc4b3750-9b7d-4a43-9c99-045642717cca"),
                columns: new[] { "CurrentQuantity", "ExpiryDate" },
                values: new object[] { 100, new DateTime(2023, 3, 30, 10, 57, 10, 373, DateTimeKind.Local).AddTicks(877) });
        }
    }
}
