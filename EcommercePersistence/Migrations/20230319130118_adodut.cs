using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EcommercePersistence.Migrations
{
    /// <inheritdoc />
    public partial class adodut : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CatregoryId", "CurrentQuantity", "ExpiryDate", "MinimumQuantity", "Name", "SellPrice" },
                values: new object[,]
                {
                    { new Guid("08ac377c-ba18-40ab-a496-a5286185036d"), null, 200m, new DateTime(2023, 3, 19, 15, 1, 17, 913, DateTimeKind.Local).AddTicks(3003), 10m, "P1", 100m },
                    { new Guid("cc4b3750-9b7d-4a43-9c99-045642717cca"), null, 100m, new DateTime(2023, 3, 19, 15, 1, 17, 913, DateTimeKind.Local).AddTicks(3057), 10m, "P2", 200m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("08ac377c-ba18-40ab-a496-a5286185036d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cc4b3750-9b7d-4a43-9c99-045642717cca"));
        }
    }
}
