using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcommercePersistence.Migrations
{
    /// <inheritdoc />
    public partial class producttransactions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductTransaction_Products_ProductId",
                table: "ProductTransaction");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductTransaction",
                table: "ProductTransaction");

            migrationBuilder.RenameTable(
                name: "ProductTransaction",
                newName: "Producttransactions");

            migrationBuilder.RenameIndex(
                name: "IX_ProductTransaction_ProductId",
                table: "Producttransactions",
                newName: "IX_Producttransactions_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Producttransactions",
                table: "Producttransactions",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("08ac377c-ba18-40ab-a496-a5286185036d"),
                column: "ExpiryDate",
                value: new DateTime(2023, 3, 30, 10, 57, 10, 373, DateTimeKind.Local).AddTicks(783));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cc4b3750-9b7d-4a43-9c99-045642717cca"),
                column: "ExpiryDate",
                value: new DateTime(2023, 3, 30, 10, 57, 10, 373, DateTimeKind.Local).AddTicks(877));

            migrationBuilder.AddForeignKey(
                name: "FK_Producttransactions_Products_ProductId",
                table: "Producttransactions",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Producttransactions_Products_ProductId",
                table: "Producttransactions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Producttransactions",
                table: "Producttransactions");

            migrationBuilder.RenameTable(
                name: "Producttransactions",
                newName: "ProductTransaction");

            migrationBuilder.RenameIndex(
                name: "IX_Producttransactions_ProductId",
                table: "ProductTransaction",
                newName: "IX_ProductTransaction_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductTransaction",
                table: "ProductTransaction",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("08ac377c-ba18-40ab-a496-a5286185036d"),
                column: "ExpiryDate",
                value: new DateTime(2023, 3, 24, 14, 17, 20, 2, DateTimeKind.Local).AddTicks(3421));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cc4b3750-9b7d-4a43-9c99-045642717cca"),
                column: "ExpiryDate",
                value: new DateTime(2023, 3, 24, 14, 17, 20, 2, DateTimeKind.Local).AddTicks(3475));

            migrationBuilder.AddForeignKey(
                name: "FK_ProductTransaction_Products_ProductId",
                table: "ProductTransaction",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
