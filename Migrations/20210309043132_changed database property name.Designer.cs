﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using street_foody.Models;

namespace street_foody.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20210309043132_changed database property name")]
    partial class changeddatabasepropertyname
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("FoodStreetVendor", b =>
                {
                    b.Property<string>("FoodsFoodID")
                        .HasColumnType("text")
                        .HasColumnName("foods_food_id");

                    b.Property<string>("StreetVendorsVendorID")
                        .HasColumnType("text")
                        .HasColumnName("street_vendors_vendor_id");

                    b.HasKey("FoodsFoodID", "StreetVendorsVendorID")
                        .HasName("pk_food_street_vendor");

                    b.HasIndex("StreetVendorsVendorID")
                        .HasDatabaseName("ix_food_street_vendor_street_vendors_vendor_id");

                    b.ToTable("food_street_vendor");
                });

            modelBuilder.Entity("street_foody.Models.Food", b =>
                {
                    b.Property<string>("FoodID")
                        .HasColumnType("text")
                        .HasColumnName("food_id");

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("EnglishName")
                        .HasColumnType("text")
                        .HasColumnName("english_name");

                    b.Property<string>("FoodCategoryID")
                        .HasColumnType("text")
                        .HasColumnName("food_category_id");

                    b.Property<string>("PhotoUrl")
                        .HasColumnType("text")
                        .HasColumnName("photo_url");

                    b.Property<double>("Price")
                        .HasColumnType("double precision")
                        .HasColumnName("price");

                    b.Property<string>("VietnameseName")
                        .HasColumnType("text")
                        .HasColumnName("vietnamese_name");

                    b.HasKey("FoodID")
                        .HasName("pk_food");

                    b.HasIndex("FoodCategoryID")
                        .HasDatabaseName("ix_food_food_category_id");

                    b.ToTable("food");
                });

            modelBuilder.Entity("street_foody.Models.FoodCategory", b =>
                {
                    b.Property<string>("FoodCategoryID")
                        .HasColumnType("text")
                        .HasColumnName("food_category_id");

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("EnglishName")
                        .HasColumnType("text")
                        .HasColumnName("english_name");

                    b.Property<string>("VietnameseName")
                        .HasColumnType("text")
                        .HasColumnName("vietnamese_name");

                    b.HasKey("FoodCategoryID")
                        .HasName("pk_food_category");

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

                    b.Property<string>("EnglishName")
                        .HasColumnType("text")
                        .HasColumnName("english_name");

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

                    b.Property<string>("VendorName")
                        .HasColumnType("text")
                        .HasColumnName("vendor_name");

                    b.Property<string>("VietnameseName")
                        .HasColumnType("text")
                        .HasColumnName("vietnamese_name");

                    b.HasKey("VendorID")
                        .HasName("pk_street_vendor");

                    b.ToTable("street_vendor");

                    b.HasData(
                        new
                        {
                            VendorID = "1",
                            EnglishName = "Tran Binh Trong rice noodles",
                            PhotoUrl = "https://static.riviu.co/640/image/2020/09/04/bef16221de75b45fea2dd579b5c9a29a_output.jpeg",
                            PriceRange = new[] { 15000, 30000 },
                            RatingList = new[] { 4, 4, 4 },
                            VietnameseName = "Hủ tiếu Trần Bình Trọng"
                        },
                        new
                        {
                            VendorID = "2",
                            EnglishName = "Aunty Loan's banh mi",
                            PriceRange = new[] { 15000, 20000 },
                            RatingList = new[] { 5 },
                            VietnameseName = "Bánh mì Dì Loan"
                        },
                        new
                        {
                            VendorID = "3",
                            EnglishName = "Miến xào",
                            PriceRange = new[] { 10000, 15000 },
                            RatingList = new[] { 5 },
                            VietnameseName = "Miến xào"
                        },
                        new
                        {
                            VendorID = "4",
                            EnglishName = "Sticky rice",
                            PriceRange = new[] { 10000, 15000 },
                            RatingList = new[] { 3 },
                            VietnameseName = "Xôi"
                        },
                        new
                        {
                            VendorID = "5",
                            EnglishName = "Vinh Vien St. snacks and boba tea",
                            PhotoUrl = "https://scontent.ffcm1-2.fna.fbcdn.net/v/t1.0-9/156646575_817247045527459_8464517707157016028_n.jpg?_nc_cat=1&ccb=3&_nc_sid=b9115d&_nc_ohc=7qGQxbPz5GIAX94w5F1&_nc_ht=scontent.ffcm1-2.fna&oh=66f3c0a1330121b1100836f404c5ced8&oe=60685917",
                            PriceRange = new[] { 14000, 29000 },
                            RatingList = new int[0],
                            VietnameseName = "Ăn vặt, trà sữa đường Vĩnh Viễn"
                        },
                        new
                        {
                            VendorID = "6",
                            EnglishName = "Bau Sen market beef vermicelli soup",
                            PhotoUrl = "https://scontent.ffcm1-2.fna.fbcdn.net/v/t1.0-9/84698123_1286864361515233_6961019376854106112_n.jpg?_nc_cat=108&ccb=3&_nc_sid=730e14&_nc_ohc=E1KHA4sGlc4AX_ZY4Mn&_nc_ht=scontent.ffcm1-2.fna&oh=8a56d06173f2342f91f7da037f89fff0&oe=60666BCB",
                            PriceRange = new[] { 35000, 45000 },
                            RatingList = new[] { 5 },
                            VietnameseName = "Bún bò Bàu Sen"
                        },
                        new
                        {
                            VendorID = "7",
                            EnglishName = "Anva boba tea",
                            PhotoUrl = "https://scontent.ffcm1-2.fna.fbcdn.net/v/t1.0-9/155165695_240195354407050_2744091707808776661_n.jpg?_nc_cat=101&ccb=3&_nc_sid=8bfeb9&_nc_ohc=05vpqk1kzbAAX9TFzD4&_nc_ht=scontent.ffcm1-2.fna&oh=6b0b19a21677cc60dc3c605d0746e109&oe=606906E4",
                            PriceRange = new[] { 99999999, 99999999 },
                            RatingList = new int[0],
                            VietnameseName = "Trà sữa Anva"
                        },
                        new
                        {
                            VendorID = "8",
                            EnglishName = "Chubby sis's sweet sticky rice",
                            PhotoUrl = "https://scontent.ffcm1-2.fna.fbcdn.net/v/t1.0-9/155122691_1246898299037777_4391716006726234458_n.jpg?_nc_cat=107&ccb=3&_nc_sid=b9115d&_nc_ohc=Oh-3nRYX_ywAX_XtP7F&_nc_ht=scontent.ffcm1-2.fna&oh=6d0ae3ea925ae24e6cc4fefe7eb8f5ec&oe=606915A1",
                            PriceRange = new[] { 20000, 25000 },
                            VietnameseName = "Xôi ngọt chị Ú"
                        },
                        new
                        {
                            VendorID = "9",
                            EnglishName = "Tiger Tea",
                            PhotoUrl = "https://scontent.ffcm1-1.fna.fbcdn.net/v/t1.0-9/155512636_546860506277469_3968119529767571609_o.jpg?_nc_cat=109&ccb=3&_nc_sid=b9115d&_nc_ohc=a11O8kknWEQAX-WDDGL&_nc_ht=scontent.ffcm1-1.fna&oh=2bb5aef40ca9ab14683c771ff074e599&oe=6066F325",
                            PriceRange = new[] { 15000, 40000 },
                            RatingList = new[] { 5 },
                            VietnameseName = "Tiger Tea"
                        },
                        new
                        {
                            VendorID = "10",
                            EnglishName = "Grandma's rice paper mix",
                            PhotoUrl = "https://static.riviu.co/960/image/2021/01/23/507d435341a6bf9a8b78f73b2498cff8_output.jpeg",
                            PriceRange = new[] { 15000, 15000 },
                            RatingList = new[] { 5, 5, 5, 4 },
                            VietnameseName = "Bánh tráng Bà Ngoại"
                        },
                        new
                        {
                            VendorID = "11",
                            EnglishName = "Aunty Thuy's sweet gruel",
                            PhotoUrl = "https://cdn01.diadiemanuong.com/ddau/999x/undefined-che-co-thuy-cao-dat-0-56b16e9637305080834967437.jpg",
                            PriceRange = new[] { 10000, 15000 },
                            RatingList = new[] { 5, 5, 5, 5 },
                            VietnameseName = "Chè cô Thủy"
                        },
                        new
                        {
                            VendorID = "12",
                            EnglishName = "Grandma's banh mi",
                            PhotoUrl = "https://static.riviu.co/960/image/2020/06/15/f38acd6e2f5fa2c9e3529702ddc1f588_output.jpeg",
                            PriceRange = new[] { 20000, 25000 },
                            RatingList = new[] { 4 },
                            VietnameseName = "Bánh mì Bà Nội"
                        },
                        new
                        {
                            VendorID = "13",
                            EnglishName = "Hu tieu go 20k",
                            PhotoUrl = "https://static.riviu.co/960/image/2020/11/23/60cc5128a4dae43cef57378f30e688c0_output.jpeg",
                            PriceRange = new[] { 15000, 20000 },
                            RatingList = new[] { 5 },
                            VietnameseName = "Hủ tiếu gõ 20k"
                        },
                        new
                        {
                            VendorID = "14",
                            EnglishName = "2 uncles' popiah",
                            PhotoUrl = "https://static.riviu.co/960/image/2020/12/28/e02c4fae62a8993c43996561df2865a4_output.jpeg",
                            PriceRange = new[] { 30000, 30000 },
                            RatingList = new[] { 5 },
                            VietnameseName = "Bò bía 2 ông chú"
                        },
                        new
                        {
                            VendorID = "15",
                            EnglishName = "Green Box (Gibi)",
                            PhotoUrl = "https://static.riviu.co/960/image/2020/12/04/67fabbc325dd84ba17fdc0e6e63978e9_output.jpeg",
                            PriceRange = new[] { 5000, 40000 },
                            RatingList = new[] { 3, 4, 4 },
                            VietnameseName = "Green Box (Gibi)"
                        });
                });

            modelBuilder.Entity("street_foody.Models.VendorHours", b =>
                {
                    b.Property<string>("VendorHoursID")
                        .HasColumnType("text")
                        .HasColumnName("vendor_hours_id");

                    b.Property<string>("EndTime")
                        .HasColumnType("text")
                        .HasColumnName("end_time");

                    b.Property<string>("Location")
                        .HasColumnType("text")
                        .HasColumnName("location");

                    b.Property<string>("StartTime")
                        .HasColumnType("text")
                        .HasColumnName("start_time");

                    b.Property<string>("VendorDates")
                        .HasColumnType("text")
                        .HasColumnName("vendor_dates");

                    b.Property<string>("VendorID")
                        .HasColumnType("text")
                        .HasColumnName("vendor_id");

                    b.HasKey("VendorHoursID")
                        .HasName("pk_vendor_hours");

                    b.ToTable("vendor_hours");

                    b.HasData(
                        new
                        {
                            VendorHoursID = "1",
                            EndTime = "9pm",
                            Location = "359 Tran Binh Trong, Ward 1, District 10, HCMC",
                            StartTime = "3pm",
                            VendorDates = "Sun-Sat",
                            VendorID = "1"
                        },
                        new
                        {
                            VendorHoursID = "2",
                            EndTime = "11am",
                            Location = "15 D5 St., Ward 25, Binh Thanh District, HCMC",
                            StartTime = "5am",
                            VendorDates = "Mon-Sat",
                            VendorID = "2"
                        },
                        new
                        {
                            VendorHoursID = "3",
                            EndTime = "12pm",
                            Location = "10-12 Dinh Tien Hoang St., Ben Nghe Ward, District 1, HCMC",
                            StartTime = "10am",
                            VendorDates = "Mon-Fri",
                            VendorID = "3"
                        },
                        new
                        {
                            VendorHoursID = "4",
                            EndTime = "8am",
                            Location = "217 Hong Bang, Ward 1, District 5, HCMC",
                            StartTime = "6am",
                            VendorDates = "Mon-Fri",
                            VendorID = "4"
                        },
                        new
                        {
                            VendorHoursID = "5",
                            EndTime = "10pm",
                            Location = "82 Vinh Vien, Ward 2, District 10, HCMC",
                            StartTime = "9am",
                            VendorDates = "Sun-Sat",
                            VendorID = "5"
                        },
                        new
                        {
                            VendorHoursID = "6",
                            EndTime = "12am",
                            Location = "138 Nguyen Trai, Ward 3, District 5",
                            StartTime = "5pm",
                            VendorDates = "Sun-Sat",
                            VendorID = "6"
                        },
                        new
                        {
                            VendorHoursID = "7",
                            EndTime = "9pm",
                            Location = "267 Pham Van Chi, Ward 3, District 6",
                            StartTime = "11am",
                            VendorDates = "Sun-Sat",
                            VendorID = "7"
                        },
                        new
                        {
                            VendorHoursID = "8",
                            EndTime = "N/A",
                            Location = "8 Phan Van Han, Ward 19, Binh Thanh District",
                            StartTime = "3pm",
                            VendorDates = "Sun-Sat",
                            VendorID = "8"
                        },
                        new
                        {
                            VendorHoursID = "9",
                            EndTime = "10pm",
                            Location = "27 Thanh Da, Ward 27, Binh Thanh District",
                            StartTime = "6pm",
                            VendorDates = "Sun-Sat",
                            VendorID = "9"
                        },
                        new
                        {
                            VendorHoursID = "10",
                            EndTime = "10pm",
                            Location = "623/20 CMT8, P.15, Q.10",
                            StartTime = "5:30pm",
                            VendorDates = "Sun-Sat",
                            VendorID = "10"
                        },
                        new
                        {
                            VendorHoursID = "11",
                            EndTime = "5pm",
                            Location = "897/29 Tran Hung Dao, Ward 01, District 5, HCMC",
                            StartTime = "11am",
                            VendorDates = "Sun-Sat",
                            VendorID = "11"
                        },
                        new
                        {
                            VendorHoursID = "12",
                            EndTime = "9pm",
                            Location = "246/55A Hoa Hung, Ward 13, District 10",
                            StartTime = "6am",
                            VendorDates = "Sun-Sat",
                            VendorID = "12"
                        },
                        new
                        {
                            VendorHoursID = "13",
                            EndTime = "10pm",
                            Location = "48 Kha Van Can St., Binh Chanh Ward, Thu Duc District",
                            StartTime = "6pm",
                            VendorDates = "Sun-Sat",
                            VendorID = "13"
                        },
                        new
                        {
                            VendorHoursID = "14",
                            EndTime = "10pm",
                            Location = "Le Van Tam Park",
                            StartTime = "5pm",
                            VendorDates = "Sun-Sat",
                            VendorID = "14"
                        },
                        new
                        {
                            VendorHoursID = "15",
                            EndTime = "11pm",
                            Location = "38 Phạm Ngọc Thạch, P.6, Q.3, HCM",
                            StartTime = "12pm",
                            VendorDates = "Sun-Sat",
                            VendorID = "15"
                        });
                });

            modelBuilder.Entity("FoodStreetVendor", b =>
                {
                    b.HasOne("street_foody.Models.Food", null)
                        .WithMany()
                        .HasForeignKey("FoodsFoodID")
                        .HasConstraintName("fk_food_street_vendor_food_foods_food_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("street_foody.Models.StreetVendor", null)
                        .WithMany()
                        .HasForeignKey("StreetVendorsVendorID")
                        .HasConstraintName("fk_food_street_vendor_street_vendor_street_vendors_vendor_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("street_foody.Models.Food", b =>
                {
                    b.HasOne("street_foody.Models.FoodCategory", "FoodCategory")
                        .WithMany("Foods")
                        .HasForeignKey("FoodCategoryID")
                        .HasConstraintName("fk_food_food_category_food_category_id");

                    b.Navigation("FoodCategory");
                });

            modelBuilder.Entity("street_foody.Models.FoodCategory", b =>
                {
                    b.Navigation("Foods");
                });
#pragma warning restore 612, 618
        }
    }
}