﻿// <auto-generated />
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using street_foody.Models;

namespace street_foody.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.HasData(
                        new
                        {
                            FoodCategoryID = "1",
                            CategoryEnglishName = "Pho",
                            CategoryVietnameseName = "Phở",
                            Description = " A soup with rice noodles, herbs, and meat. Pho in Saigon tends to have a clearer broth, and can include bean sprouts, fresh sliced chili, hoisin sauce, and additional herbs. Pho is considered to be Vietnam's national dish."
                        },
                        new
                        {
                            FoodCategoryID = "2",
                            CategoryEnglishName = "Rice noodles, or simply hu tieu",
                            CategoryVietnameseName = "Hủ tiếu",
                            Description = "This noodle dish can be served with or without broth (dry) and includes pork bones, herbs, and a variety of meats and other ingredients."
                        },
                        new
                        {
                            FoodCategoryID = "3",
                            CategoryEnglishName = "Egg noodles",
                            CategoryVietnameseName = "Mì",
                            Description = "Noodles made out of wheat flour or egg noodles. These noodles can be thick or thin, and can be served in soups or dry (without broth)."
                        },
                        new
                        {
                            FoodCategoryID = "4",
                            CategoryEnglishName = "Vietnamese rice vermicelli",
                            CategoryVietnameseName = "Bún",
                            Description = "These thin rice noodles, also known as rice vermicelli, can be found in soups, served with meats and vegetables, or in goi cuon."
                        },
                        new
                        {
                            FoodCategoryID = "5",
                            CategoryEnglishName = "Tapioca noodles, banh canh",
                            CategoryVietnameseName = "Bánh canh",
                            Description = "Thick tapioca noodles that can be served with a variety of broths and toppings, which can include crab, fish cakes, pork, and more."
                        },
                        new
                        {
                            FoodCategoryID = "6",
                            CategoryEnglishName = "Cellophane noodles/glass noodles",
                            CategoryVietnameseName = "Miến",
                            Description = "Also known as cellophane or glass noodles, these help make up Vietnamese dishes like mien ga, a chicken soup. Often confused with bun, or rice vermicelli, glass noodles can be distinguished by their clear glass-like appearance when cooked."
                        },
                        new
                        {
                            FoodCategoryID = "7",
                            CategoryEnglishName = "Vietnamese macaroni",
                            CategoryVietnameseName = "Nui",
                            Description = "These noodles are Vietnamese macaroni, and are often included in Vietnamese chicken and noodle soups."
                        },
                        new
                        {
                            FoodCategoryID = "8",
                            CategoryEnglishName = "Steamed rice rolls, Rice noodle rolls",
                            CategoryVietnameseName = "Bánh cuốn",
                            Description = "Rice noodle rolls made from thin sheets of fermented rice that are steamed and filled with pork, mushrooms, and shallots."
                        },
                        new
                        {
                            FoodCategoryID = "9",
                            CategoryEnglishName = "Vietnamese broken rice",
                            CategoryVietnameseName = "Cơm tấm",
                            Description = "This dish is made from broken rice grains, and is quite popular in Saigon. It often includes grilled pork ribs, fried egg, scallions, fresh and pickled vegetables, and fish sauce."
                        },
                        new
                        {
                            FoodCategoryID = "10",
                            CategoryEnglishName = "Congee",
                            CategoryVietnameseName = "Cháo",
                            Description = "Vietnamese congee, or rice porridge. It can be combined with chicken, duck, or pork and broth, as well as vegetables, and can also be served with youtiao (a type of fried dough)."
                        },
                        new
                        {
                            FoodCategoryID = "11",
                            CategoryEnglishName = "Egg drop soup",
                            CategoryVietnameseName = "Súp",
                            Description = "A type of thick, chunky soup made from flavored soup base, egg and tapioca starch. Other typical ingredients include quail eggs, crab meat, pig brain, mushrooms and vegetables. In English, known as egg drop soup."
                        },
                        new
                        {
                            FoodCategoryID = "12",
                            CategoryEnglishName = "Sticky rice",
                            CategoryVietnameseName = "Xôi",
                            Description = ""
                        },
                        new
                        {
                            FoodCategoryID = "13",
                            CategoryEnglishName = "Vietnamese sandwich",
                            CategoryVietnameseName = "Bánh mì",
                            Description = "A sandwich made with a short baguette that often includes pork, cucumber, pickled carrots, cilantro, chili, and mayonnaise, or a wide variety of other ingredients and combinations."
                        },
                        new
                        {
                            FoodCategoryID = "14",
                            CategoryEnglishName = "Vietnamese steamed bun",
                            CategoryVietnameseName = "Bánh bao",
                            Description = "A round savory bun filled with meat, eggs, and vegetables including onions and mushrooms. Often include Chinese sausage and hard-boiled egg."
                        },
                        new
                        {
                            FoodCategoryID = "15",
                            CategoryEnglishName = "Dim sum",
                            CategoryVietnameseName = "Điểm sấm",
                            Description = "Originally from China, these can include wontons, dumplings and poststickers and other ball/bun shaped dishes eaten with or without soup. Generally, they are meat balls wrapped inside flour wrappers."
                        },
                        new
                        {
                            FoodCategoryID = "16",
                            CategoryEnglishName = "Rolls",
                            CategoryVietnameseName = "Cuốn",
                            Description = "Any Vietnamese traditional food that comes in the form of rolls, e.g. summer rolls, egg rolls, bo bia, .... Wrappers are commonly made from rice papers or betel leaves."
                        },
                        new
                        {
                            FoodCategoryID = "17",
                            CategoryEnglishName = "Crispy pancakes",
                            CategoryVietnameseName = "Pancakes",
                            Description = "These crispy, savory pancakes are made of rice flour, water, and turmeric, fried in a pan and filled with ingredients like pork, prawns, green onion, mung bean, and herbs."
                        },
                        new
                        {
                            FoodCategoryID = "18",
                            CategoryEnglishName = "Rice paper",
                            CategoryVietnameseName = "Bánh tráng",
                            Description = "Rice paper wrappers made from a mixture of rice flour with tapioca starch, water and salt. They are thin and light in texture, and often used in egg rolls and spring rolls."
                        },
                        new
                        {
                            FoodCategoryID = "19",
                            CategoryEnglishName = "Eggs",
                            CategoryVietnameseName = "Trứng",
                            Description = "Eggs (usually from a quail, a duck or a chicken), often boiled and fertilized, or soft-boiled."
                        },
                        new
                        {
                            FoodCategoryID = "20",
                            CategoryEnglishName = "Sweet cakes",
                            CategoryVietnameseName = "Bánh ngọt",
                            Description = "Sweet cakes are a type of Vietnamese dessert and come in many varieties. Cakes can often include rice flour and coconut milk, and can feature flavors like banana and cassava, among others."
                        },
                        new
                        {
                            FoodCategoryID = "21",
                            CategoryEnglishName = "Skewers",
                            CategoryVietnameseName = "Xiên que",
                            Description = "Skewered food in Vietnam can include fried fish balls, grilled corn, grilled sausage, and more."
                        },
                        new
                        {
                            FoodCategoryID = "22",
                            CategoryEnglishName = "Fruits",
                            CategoryVietnameseName = "Trái cây",
                            Description = ""
                        },
                        new
                        {
                            FoodCategoryID = "23",
                            CategoryEnglishName = "Sweet gruel",
                            CategoryVietnameseName = "Chè",
                            Description = "Sweet gruel is another Vietnamese dessert, with textures ranging from that of a soup to a pudding. Flavors vary, including fruits and chocolates, and often include coconut milk, rice, and/or tapioca."
                        },
                        new
                        {
                            FoodCategoryID = "24",
                            CategoryEnglishName = "Juice",
                            CategoryVietnameseName = "Nước ép",
                            Description = ""
                        },
                        new
                        {
                            FoodCategoryID = "25",
                            CategoryEnglishName = "Bottled drinks",
                            CategoryVietnameseName = "Nước đóng chai",
                            Description = ""
                        },
                        new
                        {
                            FoodCategoryID = "26",
                            CategoryEnglishName = "Tea",
                            CategoryVietnameseName = "Trà",
                            Description = ""
                        },
                        new
                        {
                            FoodCategoryID = "27",
                            CategoryEnglishName = "Vietnamese coffee",
                            CategoryVietnameseName = "Cà phê",
                            Description = ""
                        },
                        new
                        {
                            FoodCategoryID = "28",
                            CategoryEnglishName = "Boba tea",
                            CategoryVietnameseName = "Trà sữa",
                            Description = ""
                        },
                        new
                        {
                            FoodCategoryID = "29",
                            CategoryEnglishName = "Dessert",
                            CategoryVietnameseName = "Tráng miệng",
                            Description = ""
                        });
                });

            modelBuilder.Entity("street_foody.Models.StreetVendor", b =>
                {
                    b.Property<string>("VendorID")
                        .HasColumnType("text")
                        .HasColumnName("vendor_id");

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<int[]>("OpeningHours")
                        .HasColumnType("integer[]")
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
                            RatingList = new int[0],
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
                            PriceRange = new int[0],
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
