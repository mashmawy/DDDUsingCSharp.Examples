using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DDDUsingCSharp.Examples.Example2.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class starter : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ShippingAddressCountry = table.Column<string>(name: "ShippingAddress_Country", type: "nvarchar(max)", nullable: false),
                    ShippingAddressProvince = table.Column<string>(name: "ShippingAddress_Province", type: "nvarchar(max)", nullable: false),
                    ShippingAddressCity = table.Column<string>(name: "ShippingAddress_City", type: "nvarchar(max)", nullable: false),
                    ShippingAddressStreet = table.Column<string>(name: "ShippingAddress_Street", type: "nvarchar(max)", nullable: false),
                    ShippingAddressBuilding = table.Column<string>(name: "ShippingAddress_Building", type: "nvarchar(max)", nullable: false),
                    ShippingAddressApartment = table.Column<string>(name: "ShippingAddress_Apartment", type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItem_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_OrderId",
                table: "OrderItem",
                column: "OrderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderItem");

            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
