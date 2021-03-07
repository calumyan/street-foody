﻿// <auto-generated />
using System;
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
    [Migration("20210306222826_added a price")]
    partial class addedaprice
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

                    b.Property<string[]>("OpeningHours")
                        .HasColumnType("text[]")
                        .HasColumnName("opening_hours");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text")
                        .HasColumnName("phone_number");

                    b.Property<string>("PhotoUrl")
                        .HasColumnType("text")
                        .HasColumnName("photo_url");

                    b.Property<int[]>("PriceRange")
                        .HasColumnType("integer[]")
                        .HasColumnName("price_range");

                    b.Property<int[]>("RatingList")
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
                            PhotoUrl = "https://static.riviu.co/640/image/2020/09/04/bef16221de75b45fea2dd579b5c9a29a_output.jpeg",
                            PriceRange = new[] { 15000, 30000 },
                            RatingList = new[] { 4, 4, 4 },
                            StandEnglishName = "Tran Binh Trong rice noodles",
                            StandVietnameseName = "Hủ tiếu Trần Bình Trọng"
                        },
                        new
                        {
                            VendorID = "2",
                            PriceRange = new[] { 15000, 20000 },
                            RatingList = new[] { 5 },
                            StandEnglishName = "Aunty Loan's banh mi",
                            StandVietnameseName = "Bánh mì Dì Loan"
                        },
                        new
                        {
                            VendorID = "3",
                            PriceRange = new[] { 10000, 15000 },
                            RatingList = new[] { 5 },
                            StandEnglishName = "Miến xào",
                            StandVietnameseName = "Miến xào"
                        },
                        new
                        {
                            VendorID = "4",
                            PriceRange = new[] { 10000, 15000 },
                            RatingList = new[] { 3 },
                            StandEnglishName = "Sticky rice",
                            StandVietnameseName = "Xôi"
                        },
                        new
                        {
                            VendorID = "5",
                            PhotoUrl = "https://scontent.ffcm1-2.fna.fbcdn.net/v/t1.0-9/156646575_817247045527459_8464517707157016028_n.jpg?_nc_cat=1&ccb=3&_nc_sid=b9115d&_nc_ohc=7qGQxbPz5GIAX94w5F1&_nc_ht=scontent.ffcm1-2.fna&oh=66f3c0a1330121b1100836f404c5ced8&oe=60685917",
                            PriceRange = new[] { 14000, 29000 },
                            RatingList = new[] { 10000, 18000 },
                            StandEnglishName = "Vinh Vien St. snacks and boba tea",
                            StandVietnameseName = "Ăn vặt, trà sữa đường Vĩnh Viễn"
                        },
                        new
                        {
                            VendorID = "6",
                            PhotoUrl = "https://scontent.ffcm1-2.fna.fbcdn.net/v/t1.0-9/84698123_1286864361515233_6961019376854106112_n.jpg?_nc_cat=108&ccb=3&_nc_sid=730e14&_nc_ohc=E1KHA4sGlc4AX_ZY4Mn&_nc_ht=scontent.ffcm1-2.fna&oh=8a56d06173f2342f91f7da037f89fff0&oe=60666BCB",
                            PriceRange = new[] { 35000, 45000 },
                            RatingList = new[] { 5 },
                            StandEnglishName = "Bau Sen market beef vermicelli soup",
                            StandVietnameseName = "Bún bò Bàu Sen"
                        },
                        new
                        {
                            VendorID = "7",
                            PhotoUrl = "https://scontent.ffcm1-2.fna.fbcdn.net/v/t1.0-9/155165695_240195354407050_2744091707808776661_n.jpg?_nc_cat=101&ccb=3&_nc_sid=8bfeb9&_nc_ohc=05vpqk1kzbAAX9TFzD4&_nc_ht=scontent.ffcm1-2.fna&oh=6b0b19a21677cc60dc3c605d0746e109&oe=606906E4",
                            PriceRange = new[] { 10000, 10000 },
                            RatingList = new int[0],
                            StandEnglishName = "Anva boba tea",
                            StandVietnameseName = "Trà sữa Anva"
                        },
                        new
                        {
                            VendorID = "8",
                            PhotoUrl = "https://scontent.ffcm1-2.fna.fbcdn.net/v/t1.0-9/155122691_1246898299037777_4391716006726234458_n.jpg?_nc_cat=107&ccb=3&_nc_sid=b9115d&_nc_ohc=Oh-3nRYX_ywAX_XtP7F&_nc_ht=scontent.ffcm1-2.fna&oh=6d0ae3ea925ae24e6cc4fefe7eb8f5ec&oe=606915A1",
                            PriceRange = new[] { 20000, 25000 },
                            StandEnglishName = "Chubby sis's sweet sticky rice",
                            StandVietnameseName = "Xôi ngọt chị Ú"
                        },
                        new
                        {
                            VendorID = "9",
                            PhotoUrl = "https://scontent.ffcm1-1.fna.fbcdn.net/v/t1.0-9/155512636_546860506277469_3968119529767571609_o.jpg?_nc_cat=109&ccb=3&_nc_sid=b9115d&_nc_ohc=a11O8kknWEQAX-WDDGL&_nc_ht=scontent.ffcm1-1.fna&oh=2bb5aef40ca9ab14683c771ff074e599&oe=6066F325",
                            PriceRange = new[] { 15000, 40000 },
                            RatingList = new[] { 5 },
                            StandEnglishName = "Tiger Tea",
                            StandVietnameseName = "Tiger Tea"
                        },
                        new
                        {
                            VendorID = "10",
                            PhotoUrl = "https://static.riviu.co/960/image/2021/01/23/507d435341a6bf9a8b78f73b2498cff8_output.jpeg",
                            PriceRange = new[] { 15000, 15000 },
                            RatingList = new[] { 5, 5, 5, 4 },
                            StandEnglishName = "Grandma's rice paper mix",
                            StandVietnameseName = "Bánh tráng Bà Ngoại"
                        },
                        new
                        {
                            VendorID = "11",
                            PhotoUrl = "https://cdn01.diadiemanuong.com/ddau/999x/undefined-che-co-thuy-cao-dat-0-56b16e9637305080834967437.jpg",
                            PriceRange = new[] { 10000, 15000 },
                            RatingList = new[] { 5, 5, 5, 5 },
                            StandEnglishName = "Aunty Thuy's sweet gruel",
                            StandVietnameseName = "Chè cô Thủy"
                        },
                        new
                        {
                            VendorID = "12",
                            PhotoUrl = "https://static.riviu.co/960/image/2020/06/15/f38acd6e2f5fa2c9e3529702ddc1f588_output.jpeg",
                            PriceRange = new[] { 20000, 25000 },
                            RatingList = new[] { 4 },
                            StandEnglishName = "Grandma's banh mi",
                            StandVietnameseName = "Bánh mì Bà Nội"
                        },
                        new
                        {
                            VendorID = "13",
                            PhotoUrl = "https://static.riviu.co/960/image/2020/11/23/60cc5128a4dae43cef57378f30e688c0_output.jpeg",
                            PriceRange = new[] { 15000, 20000 },
                            RatingList = new[] { 5 },
                            StandEnglishName = "Hu tieu go 20k",
                            StandVietnameseName = "Hủ tiếu gõ 20k"
                        },
                        new
                        {
                            VendorID = "14",
                            PhotoUrl = "https://static.riviu.co/960/image/2020/12/28/e02c4fae62a8993c43996561df2865a4_output.jpeg",
                            PriceRange = new[] { 30000, 30000 },
                            RatingList = new[] { 5 },
                            StandEnglishName = "2 uncles' popiah",
                            StandVietnameseName = "Bò bía 2 ông chú"
                        },
                        new
                        {
                            VendorID = "15",
                            PhotoUrl = "https://static.riviu.co/960/image/2020/12/04/67fabbc325dd84ba17fdc0e6e63978e9_output.jpeg",
                            PriceRange = new[] { 5000, 40000 },
                            RatingList = new[] { 3, 4, 4 },
                            StandEnglishName = "Green Box (Gibi)",
                            StandVietnameseName = "Green Box (Gibi)"
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
