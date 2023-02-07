﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjectRbRuRe.Data;

#nullable disable

namespace ProjectRbRuRe.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20230206102039_updatecartstoreid1")]
    partial class updatecartstoreid1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProjectRbRuRe.Data.ModelData.TableAmphoe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("acode")
                        .HasColumnType("int");

                    b.Property<string>("aname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("pcode")
                        .HasColumnType("int");

                    b.Property<string>("pname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Amphoe");
                });

            modelBuilder.Entity("ProjectRbRuRe.Data.ModelData.TableCartProduct", b =>
                {
                    b.Property<int>("CartProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CartProductID"));

                    b.Property<int?>("CartProductAmount")
                        .HasColumnType("int");

                    b.Property<string>("CartProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("CartProductPrice")
                        .HasColumnType("float");

                    b.Property<int?>("CartProductProductID")
                        .HasColumnType("int");

                    b.Property<int?>("CartProductStoreID")
                        .HasColumnType("int");

                    b.Property<double?>("CartProductSumPrice")
                        .HasColumnType("float");

                    b.Property<string>("CartProductUnit")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CartProductID");

                    b.ToTable("CartProduct");
                });

            modelBuilder.Entity("ProjectRbRuRe.Data.ModelData.TableCartStore", b =>
                {
                    b.Property<int>("CartStoreID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CartStoreID"));

                    b.Property<int?>("CartStoreUserID")
                        .HasColumnType("int");

                    b.Property<int>("IDLink")
                        .HasColumnType("int");

                    b.Property<string>("NameStore")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CartStoreID");

                    b.ToTable("CartStore");
                });

            modelBuilder.Entity("ProjectRbRuRe.Data.ModelData.TableOrder", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderID"));

                    b.Property<string>("OrderAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OrderDateCreate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("OrderDateEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("OrderDatePaySuccess")
                        .HasColumnType("datetime2");

                    b.Property<string>("OrderDistrict")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrderImgPay")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrderNameExpress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrderNumberExpress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrderPostcode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrderProvince")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrderStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrderStoreID")
                        .HasColumnType("int");

                    b.Property<string>("OrderStoreName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrderSubDistrict")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("OrderSumPrice")
                        .HasColumnType("float");

                    b.Property<string>("OrderTel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrderUserID")
                        .HasColumnType("int");

                    b.Property<string>("Ordername")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrderID");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("ProjectRbRuRe.Data.ModelData.TableOrderItem", b =>
                {
                    b.Property<int>("OrderItemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderItemID"));

                    b.Property<int>("OrderItemOrderID")
                        .HasColumnType("int");

                    b.Property<int?>("OrderItemProductAmount")
                        .HasColumnType("int");

                    b.Property<int?>("OrderItemProductID")
                        .HasColumnType("int");

                    b.Property<string>("OrderItemProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("OrderItemProductPrice")
                        .HasColumnType("float");

                    b.Property<double?>("OrderItemProductSumPrice")
                        .HasColumnType("float");

                    b.HasKey("OrderItemID");

                    b.ToTable("OrderItem");
                });

            modelBuilder.Entity("ProjectRbRuRe.Data.ModelData.TableProduct", b =>
                {
                    b.Property<int>("IDProduct")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IDProduct"));

                    b.Property<string>("NameProduct")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("PriceProduct")
                        .HasColumnType("float");

                    b.Property<int>("ProductCartID")
                        .HasColumnType("int");

                    b.Property<string>("ProductDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductImg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductStoreID")
                        .HasColumnType("int");

                    b.Property<string>("ProductStoreName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RemainderProduct")
                        .HasColumnType("int");

                    b.Property<string>("UnitProduct")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IDProduct");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("ProjectRbRuRe.Data.ModelData.TableProvince", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("pcode")
                        .HasColumnType("int");

                    b.Property<string>("pname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("type_soilder")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Province");
                });

            modelBuilder.Entity("ProjectRbRuRe.Data.ModelData.TableReport", b =>
                {
                    b.Property<int>("ReportID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReportID"));

                    b.Property<DateTime>("ReportDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ReportOrderID")
                        .HasColumnType("int");

                    b.Property<int?>("ReportOrderItemID")
                        .HasColumnType("int");

                    b.Property<double?>("ReportPriceSum")
                        .HasColumnType("float");

                    b.Property<string>("ReportStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReportStoreID")
                        .HasColumnType("int");

                    b.Property<string>("ReportStoreName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ReportUserID")
                        .HasColumnType("int");

                    b.Property<string>("ReportUserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReportID");

                    b.ToTable("Report");
                });

            modelBuilder.Entity("ProjectRbRuRe.Data.ModelData.TableStore", b =>
                {
                    b.Property<int>("StoreID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StoreID"));

                    b.Property<string>("AccountName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccountNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BankName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgCover")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgProfile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SellerDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SellerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("StoreID");

                    b.ToTable("Store");
                });

            modelBuilder.Entity("ProjectRbRuRe.Data.ModelData.TableUser", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserID"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("District")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Permission")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Postcode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Province")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StoreName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubDistrict")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.ToTable("User");
                });

            modelBuilder.Entity("ProjectRbRuRe.Data.ModelData.Tabletambol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("acode")
                        .HasColumnType("int");

                    b.Property<string>("aname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("pcode")
                        .HasColumnType("int");

                    b.Property<string>("pname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("tcode")
                        .HasColumnType("int");

                    b.Property<string>("tname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("tambol");
                });
#pragma warning restore 612, 618
        }
    }
}
