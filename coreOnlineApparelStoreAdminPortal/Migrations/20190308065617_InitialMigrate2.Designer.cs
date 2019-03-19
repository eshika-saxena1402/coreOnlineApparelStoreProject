﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using coreOnlineApparelStoreAdminPortal.Models;

namespace coreOnlineApparelStoreAdminPortal.Migrations
{
    [DbContext(typeof(DbContextClass))]
    [Migration("20190308065617_InitialMigrate2")]
    partial class InitialMigrate2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("coreOnlineApparelStoreAdminPortal.Models.Brand", b =>
                {
                    b.Property<int>("BrandId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BrandDescription");

                    b.Property<string>("BrandName")
                        .IsRequired();

                    b.HasKey("BrandId");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("coreOnlineApparelStoreAdminPortal.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryDescription");

                    b.Property<string>("CategoryName")
                        .IsRequired();

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("coreOnlineApparelStoreAdminPortal.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("Address2");

                    b.Property<string>("Country");

                    b.Property<string>("CustomerFirstName");

                    b.Property<string>("CustomerLastName");

                    b.Property<string>("Email");

                    b.Property<bool>("SameAddress");

                    b.Property<string>("State");

                    b.Property<string>("UserName");

                    b.Property<int>("ZipCode");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("coreOnlineApparelStoreAdminPortal.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId");

                    b.Property<double>("OrderAmount");

                    b.Property<DateTime>("OrderDate");

                    b.HasKey("OrderId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("coreOnlineApparelStoreAdminPortal.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrandId");

                    b.Property<int>("CategoryId");

                    b.Property<string>("ProductDescription");

                    b.Property<string>("ProductImage");

                    b.Property<string>("ProductName")
                        .IsRequired();

                    b.Property<float>("ProductPrice");

                    b.Property<int>("ProductQuantity");

                    b.Property<string>("ProductSize")
                        .IsRequired();

                    b.Property<int>("VendorId");

                    b.HasKey("ProductId");

                    b.HasIndex("BrandId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("VendorId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("coreOnlineApparelStoreAdminPortal.Models.Vendor", b =>
                {
                    b.Property<int>("VendorId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("VendorEmail")
                        .IsRequired();

                    b.Property<string>("VendorName")
                        .IsRequired();

                    b.Property<long>("VendorPhoneNo");

                    b.HasKey("VendorId");

                    b.ToTable("Vendors");
                });

            modelBuilder.Entity("coreOnlineApparelStoreAdminPortal.Models.Order", b =>
                {
                    b.HasOne("coreOnlineApparelStoreAdminPortal.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("coreOnlineApparelStoreAdminPortal.Models.Product", b =>
                {
                    b.HasOne("coreOnlineApparelStoreAdminPortal.Models.Brand", "Brand")
                        .WithMany("Products")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("coreOnlineApparelStoreAdminPortal.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("coreOnlineApparelStoreAdminPortal.Models.Vendor", "Vendor")
                        .WithMany("Products")
                        .HasForeignKey("VendorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}