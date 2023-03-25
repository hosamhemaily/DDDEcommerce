using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcommercePersistence.Migrations
{
    /// <inheritdoc />
    public partial class addproducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CurrentQuantity",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "ProductTransaction",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    transactiontype = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    transactionDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTransaction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductTransaction_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("08ac377c-ba18-40ab-a496-a5286185036d"),
                columns: new[] { "CurrentQuantity", "ExpiryDate" },
                values: new object[] { 200, new DateTime(2023, 3, 24, 14, 17, 20, 2, DateTimeKind.Local).AddTicks(3421) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cc4b3750-9b7d-4a43-9c99-045642717cca"),
                columns: new[] { "CurrentQuantity", "ExpiryDate" },
                values: new object[] { 100, new DateTime(2023, 3, 24, 14, 17, 20, 2, DateTimeKind.Local).AddTicks(3475) });

            migrationBuilder.CreateIndex(
                name: "IX_ProductTransaction_ProductId",
                table: "ProductTransaction",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductTransaction");

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
                values: new object[] { 200m, new DateTime(2023, 3, 19, 15, 1, 17, 913, DateTimeKind.Local).AddTicks(3003) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cc4b3750-9b7d-4a43-9c99-045642717cca"),
                columns: new[] { "CurrentQuantity", "ExpiryDate" },
                values: new object[] { 100m, new DateTime(2023, 3, 19, 15, 1, 17, 913, DateTimeKind.Local).AddTicks(3057) });
        }
    }
}
