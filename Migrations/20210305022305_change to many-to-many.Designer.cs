﻿// <auto-generated />
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using street_foody.Models;

namespace street_foody.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20210305022305_change to many-to-many")]
    partial class changetomanytomany
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618

           
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("FoodCategoryStreetVendor", b =>
                {
                    b.Property<string>("FoodCategoriesFoodCategoryID")
                        .HasColumnType("text")
                        .HasColumnName("food_categories_food_category_id");

                    b.Property<string>("StreetVendorsVendorID")
                        .HasColumnType("text")
                        .HasColumnName("street_vendors_vendor_id");

                    b.HasKey("FoodCategoriesFoodCategoryID", "StreetVendorsVendorID")
                        .HasName("pk_food_category_street_vendor");

                    b.HasIndex("StreetVendorsVendorID")
                        .HasDatabaseName("ix_food_category_street_vendor_street_vendors_vendor_id");

                    b.ToTable("food_category_street_vendor");
                });

            modelBuilder.Entity("street_foody.Models.Food", b =>
                {
                    b.Property<string>("FoodID")
                        .HasColumnType("text")
                        .HasColumnName("food_id");

                    b.Property<List<string>>("Categories")
                        .HasColumnType("text[]")
                        .HasColumnName("categories");

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("FoodEnglishName")
                        .HasColumnType("text")
                        .HasColumnName("food_english_name");

                    b.Property<string>("FoodVietnameseName")
                        .HasColumnType("text")
                        .HasColumnName("food_vietnamese_name");

                    b.Property<string>("PhotoUrl")
                        .HasColumnType("text")
                        .HasColumnName("photo_url");

                    b.Property<double>("Price")
                        .HasColumnType("double precision")
                        .HasColumnName("price");

                    b.Property<string>("StreetVendorVendorID")
                        .HasColumnType("text")
                        .HasColumnName("street_vendor_vendor_id");

                    b.HasKey("FoodID")
                        .HasName("pk_food");

                    b.HasIndex("StreetVendorVendorID")
                        .HasDatabaseName("ix_food_street_vendor_vendor_id");

                    b.ToTable("food");
                });

            modelBuilder.Entity("street_foody.Models.FoodCategory", b =>
                {
                    b.Property<string>("FoodCategoryID")
                        .HasColumnType("text")
                        .HasColumnName("food_category_id");

                    b.Property<string>("CategoryEnglishName")
                        .HasColumnType("text")
                        .HasColumnName("category_english_name");

                    b.Property<string>("CategoryVietnameseName")
                        .HasColumnType("text")
                        .HasColumnName("category_vietnamese_name");

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("FoodID")
                        .HasColumnType("text")
                        .HasColumnName("food_id");

                    b.HasKey("FoodCategoryID")
                        .HasName("pk_food_category");

                    b.HasIndex("FoodID")
                        .HasDatabaseName("ix_food_category_food_id");

                    b.ToTable("food_category");
                });

            modelBuilder.Entity("street_foody.Models.StreetVendor", b =>
                {
                    b.Property<string>("VendorID")
                        .HasColumnType("text")
                        .HasColumnName("vendor_id");

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<List<int>>("OpeningHours")
                        .HasColumnType("integer[]")
                        .HasColumnName("opening_hours");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text")
                        .HasColumnName("phone_number");

                    b.Property<string>("PhotoUrl")
                        .HasColumnType("text")
                        .HasColumnName("photo_url");

                    b.Property<List<int>>("PriceRange")
                        .HasColumnType("integer[]")
                        .HasColumnName("price_range");

                    b.Property<List<int>>("RatingList")
                        .HasColumnType("integer[]")
                        .HasColumnName("rating_list");

                    b.Property<string>("StandEnglishName")
                        .HasColumnType("text")
                        .HasColumnName("stand_english_name");

                    b.Property<string>("StandVietnameseName")
                        .HasColumnType("text")
                        .HasColumnName("stand_vietnamese_name");

                    b.Property<string>("VendorName")
                        .HasColumnType("text")
                        .HasColumnName("vendor_name");

                    b.HasKey("VendorID")
                        .HasName("pk_street_vendor");

                    b.ToTable("street_vendor");

                    b.HasData(
                        new
                        {
                            VendorID = "1",
                            StandVietnameseName = "Uncle Myles's Bahn Mi"
                        },
                        new
                        {
                            VendorID = "2",
                            StandVietnameseName = "Aunt Andie's Bahn Mi"
                        },
                        new
                        {
                            VendorID = "3",
                            StandVietnameseName = "Aunt Carrie's Bahn Mi"
                        },
                        new
                        {
                            VendorID = "4",
                            StandVietnameseName = "Aunt Lucy's Bahn Mi"
                        });
                });

            modelBuilder.Entity("street_foody.Models.VendorHours", b =>
                {
                    b.Property<string>("VendorHoursInfo")
                        .HasColumnType("text")
                        .HasColumnName("vendor_hours_info");

                    b.Property<string>("EndTime")
                        .HasColumnType("text")
                        .HasColumnName("end_time");

                    b.Property<string>("Location")
                        .HasColumnType("text")
                        .HasColumnName("location");

                    b.Property<string>("StartTime")
                        .HasColumnType("text")
                        .HasColumnName("start_time");

                    b.Property<string>("VendorID")
                        .HasColumnType("text")
                        .HasColumnName("vendor_id");

                    b.HasKey("VendorHoursInfo")
                        .HasName("pk_vendor_hours");

                    b.ToTable("vendor_hours");
                });

            modelBuilder.Entity("FoodCategoryStreetVendor", b =>
                {
                    b.HasOne("street_foody.Models.FoodCategory", null)
                        .WithMany()
                        .HasForeignKey("FoodCategoriesFoodCategoryID")
                        .HasConstraintName("fk_food_category_street_vendor_food_category_food_categories_f")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("street_foody.Models.StreetVendor", null)
                        .WithMany()
                        .HasForeignKey("StreetVendorsVendorID")
                        .HasConstraintName("fk_food_category_street_vendor_street_vendor_street_vendors_ve")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("street_foody.Models.Food", b =>
                {
                    b.HasOne("street_foody.Models.StreetVendor", null)
                        .WithMany("Menu")
                        .HasForeignKey("StreetVendorVendorID")
                        .HasConstraintName("fk_food_street_vendor_street_vendor_vendor_id");
                });

            modelBuilder.Entity("street_foody.Models.FoodCategory", b =>
                {
                    b.HasOne("street_foody.Models.Food", null)
                        .WithMany("FoodCategories")
                        .HasForeignKey("FoodID")
                        .HasConstraintName("fk_food_category_food_food_id");
                });

            modelBuilder.Entity("street_foody.Models.Food", b =>
                {
                    b.Navigation("FoodCategories");
                });

            modelBuilder.Entity("street_foody.Models.StreetVendor", b =>
                {
                    b.Navigation("Menu");
                });
#pragma warning restore 612, 618
        }
    }
}