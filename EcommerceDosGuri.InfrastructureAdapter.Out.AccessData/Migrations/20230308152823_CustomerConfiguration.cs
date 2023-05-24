using Microsoft.EntityFrameworkCore.Migrations;
using System;

#nullable disable

namespace EcommerceDosGuri.InfrastructureAdapter.Out.AccessData.Migrations
{
    /// <inheritdoc />
    public partial class CustomerConfiguration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Cpf",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "RegistrationDate",
                table: "Products",
                newName: "CreationTime");

            migrationBuilder.RenameColumn(
                name: "IsAvailable",
                table: "Products",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "RegistrationDate",
                table: "Order",
                newName: "CreationTime");

            migrationBuilder.RenameColumn(
                name: "RegistrationDate",
                table: "Customers",
                newName: "InativatedDate");

            migrationBuilder.AddColumn<DateTime>(
                name: "InativatedDate",
                table: "Products",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "QuantityInStock",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "InativatedDate",
                table: "Order",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Order",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Order",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Document",
                table: "Customers",
                type: "nvarchar(14)",
                maxLength: 14,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Customers",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InativatedDate",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "QuantityInStock",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "InativatedDate",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Document",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Products",
                newName: "IsAvailable");

            migrationBuilder.RenameColumn(
                name: "CreationTime",
                table: "Products",
                newName: "RegistrationDate");

            migrationBuilder.RenameColumn(
                name: "CreationTime",
                table: "Order",
                newName: "RegistrationDate");

            migrationBuilder.RenameColumn(
                name: "InativatedDate",
                table: "Customers",
                newName: "RegistrationDate");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Cpf",
                table: "Customers",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Customers",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: false,
                defaultValue: "");
        }
    }
}
