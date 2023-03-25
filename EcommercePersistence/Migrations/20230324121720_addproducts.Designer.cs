﻿// <auto-generated />
using System;
using EcommercePersistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EcommercePersistence.Migrations
{
    [DbContext(typeof(ProductContext))]
    [Migration("20230324121720_addproducts")]
    partial class addproducts
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EcommerceDomain.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("EcommerceDomain.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CatregoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("CurrentQuantity")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ExpiryDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("MinimumQuantity")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("SellPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CatregoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("08ac377c-ba18-40ab-a496-a5286185036d"),
                            CurrentQuantity = 200,
                            ExpiryDate = new DateTime(2023, 3, 24, 14, 17, 20, 2, DateTimeKind.Local).AddTicks(3421),
                            MinimumQuantity = 10m,
                            Name = "P1",
                            SellPrice = 0m
                        },
                        new
                        {
                            Id = new Guid("cc4b3750-9b7d-4a43-9c99-045642717cca"),
                            CurrentQuantity = 100,
                            ExpiryDate = new DateTime(2023, 3, 24, 14, 17, 20, 2, DateTimeKind.Local).AddTicks(3475),
                            MinimumQuantity = 10m,
                            Name = "P2",
                            SellPrice = 0m
                        });
                });

            modelBuilder.Entity("EcommerceDomain.ProductTransactions.ProductTransaction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<DateTime>("transactionDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("transactiontype")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductTransaction");
                });

            modelBuilder.Entity("EcommerceDomain.Product", b =>
                {
                    b.HasOne("EcommerceDomain.Category", "Catregory")
                        .WithMany()
                        .HasForeignKey("CatregoryId");

                    b.Navigation("Catregory");
                });

            modelBuilder.Entity("EcommerceDomain.ProductTransactions.ProductTransaction", b =>
                {
                    b.HasOne("EcommerceDomain.Product", null)
                        .WithMany("ProductTransactions")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EcommerceDomain.Product", b =>
                {
                    b.Navigation("ProductTransactions");
                });
#pragma warning restore 612, 618
        }
    }
}
