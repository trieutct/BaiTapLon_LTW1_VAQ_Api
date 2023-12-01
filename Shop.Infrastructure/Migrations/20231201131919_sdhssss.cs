using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shop.Infrastructure.Migrations
{
    public partial class sdhssss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Create_at",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "Update_at",
                table: "Product");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "Product",
                newName: "SoLuong");

            migrationBuilder.RenameColumn(
                name: "ProductName",
                table: "Product",
                newName: "TenSanPham");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Product",
                newName: "Gia");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Product",
                newName: "MoTa");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "Product",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Product",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Product");

            migrationBuilder.RenameColumn(
                name: "TenSanPham",
                table: "Product",
                newName: "ProductName");

            migrationBuilder.RenameColumn(
                name: "SoLuong",
                table: "Product",
                newName: "Quantity");

            migrationBuilder.RenameColumn(
                name: "MoTa",
                table: "Product",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "Gia",
                table: "Product",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Product",
                newName: "ProductId");

            migrationBuilder.AddColumn<DateTime>(
                name: "Create_at",
                table: "Product",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Update_at",
                table: "Product",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
