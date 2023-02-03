using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectRbRuRe.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CartProduct",
                columns: table => new
                {
                    CartProductID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CartProductProductID = table.Column<int>(type: "int", nullable: true),
                    CartProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CartProductAmount = table.Column<int>(type: "int", nullable: true),
                    CartProductUnit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CartProductPrice = table.Column<double>(type: "float", nullable: true),
                    CartProductSumPrice = table.Column<double>(type: "float", nullable: true),
                    CartProductStoreID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartProduct", x => x.CartProductID);
                });

            migrationBuilder.CreateTable(
                name: "CartStore",
                columns: table => new
                {
                    CartStoreID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameStore = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CartStoreUserID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartStore", x => x.CartStoreID);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderSumPrice = table.Column<double>(type: "float", nullable: true),
                    OrderUserID = table.Column<int>(type: "int", nullable: false),
                    Ordername = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderProvince = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderDistrict = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderSubDistrict = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderTel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderPostcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderStoreID = table.Column<int>(type: "int", nullable: false),
                    OrderStoreName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderDateCreate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderDateEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderDatePaySuccess = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderExpress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderNameExpress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderNumberExpress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderImgPay = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.OrderID);
                });

            migrationBuilder.CreateTable(
                name: "OrderItem",
                columns: table => new
                {
                    OrderItemID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderItemProductID = table.Column<int>(type: "int", nullable: true),
                    OrderItemProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderItemProductAmount = table.Column<int>(type: "int", nullable: true),
                    OrderItemProductPrice = table.Column<double>(type: "float", nullable: true),
                    OrderItemProductSumPrice = table.Column<double>(type: "float", nullable: true),
                    OrderItemOrderID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItem", x => x.OrderItemID);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    IDProduct = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameProduct = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RemainderProduct = table.Column<int>(type: "int", nullable: true),
                    UnitProduct = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PriceProduct = table.Column<double>(type: "float", nullable: true),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductStoreID = table.Column<int>(type: "int", nullable: false),
                    ProductStoreName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductCartID = table.Column<int>(type: "int", nullable: false),
                    ProductImg = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.IDProduct);
                });

            migrationBuilder.CreateTable(
                name: "Report",
                columns: table => new
                {
                    ReportID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReportUserID = table.Column<int>(type: "int", nullable: true),
                    ReportUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportOrderID = table.Column<int>(type: "int", nullable: true),
                    ReportOrderItemID = table.Column<int>(type: "int", nullable: true),
                    ReportPriceSum = table.Column<double>(type: "float", nullable: true),
                    ReportDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReportStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportStoreID = table.Column<int>(type: "int", nullable: false),
                    ReportStoreName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Report", x => x.ReportID);
                });

            migrationBuilder.CreateTable(
                name: "Store",
                columns: table => new
                {
                    StoreID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SellerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SellerDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BankName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    ImgProfile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgCover = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Store", x => x.StoreID);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Permission = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Province = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubDistrict = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Postcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StoreName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartProduct");

            migrationBuilder.DropTable(
                name: "CartStore");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "OrderItem");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Report");

            migrationBuilder.DropTable(
                name: "Store");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
