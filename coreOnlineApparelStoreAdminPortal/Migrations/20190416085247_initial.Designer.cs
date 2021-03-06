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
    [Migration("20190416085247_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("coreOnlineApparelStoreAdminPortal.Models.Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<long>("AlternatePhoneNumber");

                    b.Property<string>("Country");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("Gender");

                    b.Property<string>("LastName");

                    b.Property<string>("Password");

                    b.Property<long>("PhoneNumber");

                    b.Property<string>("State");

                    b.Property<int>("ZipCode");

                    b.HasKey("AdminId");

                    b.ToTable("Admins");
                });

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

            modelBuilder.Entity("coreOnlineApparelStoreAdminPortal.Models.Cart", b =>
                {
                    b.Property<int>("CartId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId");

                    b.Property<DateTime>("ItemCreated");

                    b.Property<int>("ProductId");

                    b.Property<int>("Quantity");

                    b.Property<double>("TotalAmount");

                    b.HasKey("CartId");

                    b.HasIndex("CustomerId")
                        .IsUnique();

                    b.HasIndex("ProductId");

                    b.ToTable("Carts");
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

                    b.Property<long>("AlternatePhoneNumber");

                    b.Property<string>("Country");

                    b.Property<string>("Country2");

                    b.Property<string>("CustomerFirstName");

                    b.Property<string>("CustomerLastName");

                    b.Property<string>("Email");

                    b.Property<string>("Gender");

                    b.Property<string>("Password");

                    b.Property<long>("PhoneNumber");

                    b.Property<bool>("SameAddress");

                    b.Property<string>("State");

                    b.Property<string>("State2");

                    b.Property<string>("UserName");

                    b.Property<int>("ZipCode");

                    b.Property<int>("ZipCode2");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("coreOnlineApparelStoreAdminPortal.Models.FeedBack", b =>
                {
                    b.Property<int>("FeedBackId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId");

                    b.Property<string>("Message");

                    b.HasKey("FeedBackId");

                    b.HasIndex("CustomerId");

                    b.ToTable("FeedBacks");
                });

            modelBuilder.Entity("coreOnlineApparelStoreAdminPortal.Models.Manager", b =>
                {
                    b.Property<int>("ManagerId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ManagerAddress");

                    b.Property<string>("ManagerCountry");

                    b.Property<string>("ManagerEmail");

                    b.Property<string>("ManagerFirstName");

                    b.Property<string>("ManagerGender");

                    b.Property<string>("ManagerLastName");

                    b.Property<string>("ManagerPassword");

                    b.Property<long>("ManagerPhoneNumber");

                    b.Property<string>("ManagerState");

                    b.Property<int>("ManagerZipCode");

                    b.HasKey("ManagerId");

                    b.ToTable("Managers");
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

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("coreOnlineApparelStoreAdminPortal.Models.OrderProduct", b =>
                {
                    b.Property<int>("OrderId");

                    b.Property<int>("ProductId");

                    b.Property<int>("Quantity");

                    b.HasKey("OrderId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("orderProducts");
                });

            modelBuilder.Entity("coreOnlineApparelStoreAdminPortal.Models.Payment", b =>
                {
                    b.Property<int>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Amount");

                    b.Property<int>("CardDigit");

                    b.Property<int>("CustomerId");

                    b.Property<string>("Description");

                    b.Property<int>("OrderId");

                    b.Property<DateTime>("PaymentDate");

                    b.Property<int>("StripeSettingsId");

                    b.HasKey("PaymentId");

                    b.HasIndex("OrderId")
                        .IsUnique();

                    b.HasIndex("StripeSettingsId")
                        .IsUnique();

                    b.ToTable("Payments");
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

            modelBuilder.Entity("coreOnlineApparelStoreAdminPortal.Models.StripeSettings", b =>
                {
                    b.Property<int>("StripeSettingsId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PublishableKey");

                    b.Property<string>("SecretKey");

                    b.HasKey("StripeSettingsId");

                    b.ToTable("StripeSettings");
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

            modelBuilder.Entity("coreOnlineApparelStoreAdminPortal.Models.Cart", b =>
                {
                    b.HasOne("coreOnlineApparelStoreAdminPortal.Models.Customer", "Customer")
                        .WithOne("Cart")
                        .HasForeignKey("coreOnlineApparelStoreAdminPortal.Models.Cart", "CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("coreOnlineApparelStoreAdminPortal.Models.Product", "Product")
                        .WithMany("Carts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("coreOnlineApparelStoreAdminPortal.Models.FeedBack", b =>
                {
                    b.HasOne("coreOnlineApparelStoreAdminPortal.Models.Customer", "Customer")
                        .WithMany("FeedBacks")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("coreOnlineApparelStoreAdminPortal.Models.Order", b =>
                {
                    b.HasOne("coreOnlineApparelStoreAdminPortal.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("coreOnlineApparelStoreAdminPortal.Models.OrderProduct", b =>
                {
                    b.HasOne("coreOnlineApparelStoreAdminPortal.Models.Order", "Order")
                        .WithMany("OrderProducts")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("coreOnlineApparelStoreAdminPortal.Models.Product", "Product")
                        .WithMany("OrderProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("coreOnlineApparelStoreAdminPortal.Models.Payment", b =>
                {
                    b.HasOne("coreOnlineApparelStoreAdminPortal.Models.Order", "Order")
                        .WithOne("Payment")
                        .HasForeignKey("coreOnlineApparelStoreAdminPortal.Models.Payment", "OrderId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("coreOnlineApparelStoreAdminPortal.Models.StripeSettings", "StripeSettings")
                        .WithOne("Payments")
                        .HasForeignKey("coreOnlineApparelStoreAdminPortal.Models.Payment", "StripeSettingsId")
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
