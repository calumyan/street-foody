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
    [Migration("20210309070129_vendor_hours_7_days_change")]
    partial class vendor_hours_7_days_change
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

                    b.HasData(
                        new
                        {
                            FoodCategoryID = "1",
                            Description = " A soup with rice noodles, herbs, and meat. Pho in Saigon tends to have a clearer broth, and can include bean sprouts, fresh sliced chili, hoisin sauce, and additional herbs. Pho is considered to be Vietnam's national dish.",
                            EnglishName = "Pho",
                            VietnameseName = "Phở"
                        },
                        new
                        {
                            FoodCategoryID = "2",
                            Description = "This noodle dish can be served with or without broth (dry) and includes pork bones, herbs, and a variety of meats and other ingredients.",
                            EnglishName = "Rice noodles, or simply hu tieu",
                            VietnameseName = "Hủ tiếu"
                        },
                        new
                        {
                            FoodCategoryID = "3",
                            Description = "Noodles made out of wheat flour or egg noodles. These noodles can be thick or thin, and can be served in soups or dry (without broth).",
                            EnglishName = "Egg noodles",
                            VietnameseName = "Mì"
                        },
                        new
                        {
                            FoodCategoryID = "4",
                            Description = "These thin rice noodles, also known as rice vermicelli, can be found in soups, served with meats and vegetables, or in goi cuon.",
                            EnglishName = "Vietnamese rice vermicelli",
                            VietnameseName = "Bún"
                        },
                        new
                        {
                            FoodCategoryID = "5",
                            Description = "Thick tapioca noodles that can be served with a variety of broths and toppings, which can include crab, fish cakes, pork, and more.",
                            EnglishName = "Tapioca noodles, banh canh",
                            VietnameseName = "Bánh canh"
                        },
                        new
                        {
                            FoodCategoryID = "6",
                            Description = "Also known as cellophane or glass noodles, these help make up Vietnamese dishes like mien ga, a chicken soup. Often confused with bun, or rice vermicelli, glass noodles can be distinguished by their clear glass-like appearance when cooked.",
                            EnglishName = "Cellophane noodles/glass noodles",
                            VietnameseName = "Miến"
                        },
                        new
                        {
                            FoodCategoryID = "7",
                            Description = "These noodles are Vietnamese macaroni, and are often included in Vietnamese chicken and noodle soups.",
                            EnglishName = "Vietnamese macaroni",
                            VietnameseName = "Nui"
                        },
                        new
                        {
                            FoodCategoryID = "8",
                            Description = "Rice noodle rolls made from thin sheets of fermented rice that are steamed and filled with pork, mushrooms, and shallots.",
                            EnglishName = "Steamed rice rolls, Rice noodle rolls",
                            VietnameseName = "Bánh cuốn"
                        },
                        new
                        {
                            FoodCategoryID = "9",
                            Description = "This dish is made from broken rice grains, and is quite popular in Saigon. It often includes grilled pork ribs, fried egg, scallions, fresh and pickled vegetables, and fish sauce.",
                            EnglishName = "Vietnamese broken rice",
                            VietnameseName = "Cơm tấm"
                        },
                        new
                        {
                            FoodCategoryID = "10",
                            Description = "Vietnamese congee, or rice porridge. It can be combined with chicken, duck, or pork and broth, as well as vegetables, and can also be served with youtiao (a type of fried dough).",
                            EnglishName = "Congee",
                            VietnameseName = "Cháo"
                        },
                        new
                        {
                            FoodCategoryID = "11",
                            Description = "A type of thick, chunky soup made from flavored soup base, egg and tapioca starch. Other typical ingredients include quail eggs, crab meat, pig brain, mushrooms and vegetables. In English, known as egg drop soup.",
                            EnglishName = "Egg drop soup",
                            VietnameseName = "Súp"
                        },
                        new
                        {
                            FoodCategoryID = "12",
                            Description = "",
                            EnglishName = "Sticky rice",
                            VietnameseName = "Xôi"
                        },
                        new
                        {
                            FoodCategoryID = "13",
                            Description = "A sandwich made with a short baguette that often includes pork, cucumber, pickled carrots, cilantro, chili, and mayonnaise, or a wide variety of other ingredients and combinations.",
                            EnglishName = "Vietnamese sandwich",
                            VietnameseName = "Bánh mì"
                        },
                        new
                        {
                            FoodCategoryID = "14",
                            Description = "A round savory bun filled with meat, eggs, and vegetables including onions and mushrooms. Often include Chinese sausage and hard-boiled egg.",
                            EnglishName = "Vietnamese steamed bun",
                            VietnameseName = "Bánh bao"
                        },
                        new
                        {
                            FoodCategoryID = "15",
                            Description = "Originally from China, these can include wontons, dumplings and poststickers and other ball/bun shaped dishes eaten with or without soup. Generally, they are meat balls wrapped inside flour wrappers.",
                            EnglishName = "Dim sum",
                            VietnameseName = "Điểm sấm"
                        },
                        new
                        {
                            FoodCategoryID = "16",
                            Description = "Any Vietnamese traditional food that comes in the form of rolls, e.g. summer rolls, egg rolls, bo bia, .... Wrappers are commonly made from rice papers or betel leaves.",
                            EnglishName = "Rolls",
                            VietnameseName = "Cuốn"
                        },
                        new
                        {
                            FoodCategoryID = "17",
                            Description = "These crispy, savory pancakes are made of rice flour, water, and turmeric, fried in a pan and filled with ingredients like pork, prawns, green onion, mung bean, and herbs.",
                            EnglishName = "Crispy pancakes",
                            VietnameseName = "Pancakes"
                        },
                        new
                        {
                            FoodCategoryID = "18",
                            Description = "Rice paper wrappers made from a mixture of rice flour with tapioca starch, water and salt. They are thin and light in texture, and often used in egg rolls and spring rolls.",
                            EnglishName = "Rice paper",
                            VietnameseName = "Bánh tráng"
                        },
                        new
                        {
                            FoodCategoryID = "19",
                            Description = "Eggs (usually from a quail, a duck or a chicken), often boiled and fertilized, or soft-boiled.",
                            EnglishName = "Eggs",
                            VietnameseName = "Trứng"
                        },
                        new
                        {
                            FoodCategoryID = "20",
                            Description = "Sweet cakes are a type of Vietnamese dessert and come in many varieties. Cakes can often include rice flour and coconut milk, and can feature flavors like banana and cassava, among others.",
                            EnglishName = "Sweet cakes",
                            VietnameseName = "Bánh ngọt"
                        },
                        new
                        {
                            FoodCategoryID = "21",
                            Description = "Skewered food in Vietnam can include fried fish balls, grilled corn, grilled sausage, and more.",
                            EnglishName = "Skewers",
                            VietnameseName = "Xiên que"
                        },
                        new
                        {
                            FoodCategoryID = "22",
                            Description = "",
                            EnglishName = "Fruits",
                            VietnameseName = "Trái cây"
                        },
                        new
                        {
                            FoodCategoryID = "23",
                            Description = "Sweet gruel is another Vietnamese dessert, with textures ranging from that of a soup to a pudding. Flavors vary, including fruits and chocolates, and often include coconut milk, rice, and/or tapioca.",
                            EnglishName = "Sweet gruel",
                            VietnameseName = "Chè"
                        },
                        new
                        {
                            FoodCategoryID = "24",
                            Description = "",
                            EnglishName = "Juice",
                            VietnameseName = "Nước ép"
                        },
                        new
                        {
                            FoodCategoryID = "25",
                            Description = "",
                            EnglishName = "Bottled drinks",
                            VietnameseName = "Nước đóng chai"
                        },
                        new
                        {
                            FoodCategoryID = "26",
                            Description = "",
                            EnglishName = "Tea",
                            VietnameseName = "Trà"
                        },
                        new
                        {
                            FoodCategoryID = "27",
                            Description = "",
                            EnglishName = "Vietnamese coffee",
                            VietnameseName = "Cà phê"
                        },
                        new
                        {
                            FoodCategoryID = "28",
                            Description = "",
                            EnglishName = "Boba tea",
                            VietnameseName = "Trà sữa"
                        },
                        new
                        {
                            FoodCategoryID = "29",
                            Description = "",
                            EnglishName = "Dessert",
                            VietnameseName = "Tráng miệng"
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
                    b.Property<string>("VendorID")
                        .HasColumnType("text")
                        .HasColumnName("vendor_id");

                    b.Property<DateTime[]>("Fri")
                        .HasColumnType("timestamp without time zone[]")
                        .HasColumnName("fri");

                    b.Property<string>("Location")
                        .HasColumnType("text")
                        .HasColumnName("location");

                    b.Property<DateTime[]>("Mon")
                        .HasColumnType("timestamp without time zone[]")
                        .HasColumnName("mon");

                    b.Property<DateTime[]>("Sat")
                        .HasColumnType("timestamp without time zone[]")
                        .HasColumnName("sat");

                    b.Property<DateTime[]>("Sun")
                        .HasColumnType("timestamp without time zone[]")
                        .HasColumnName("sun");

                    b.Property<DateTime[]>("Thu")
                        .HasColumnType("timestamp without time zone[]")
                        .HasColumnName("thu");

                    b.Property<DateTime[]>("Tue")
                        .HasColumnType("timestamp without time zone[]")
                        .HasColumnName("tue");

                    b.Property<DateTime[]>("Wed")
                        .HasColumnType("timestamp without time zone[]")
                        .HasColumnName("wed");

                    b.HasKey("VendorID")
                        .HasName("pk_vendor_hours");

                    b.ToTable("vendor_hours");

                    b.HasData(
                        new
                        {
                            VendorID = "1",
                            Location = "359 Tran Binh Trong, Ward 1, District 10, HCMC",
                            Sat = new[] { new DateTime(2021, 3, 9, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 21, 0, 0, 0, DateTimeKind.Unspecified) },
                            Sun = new[] { new DateTime(2021, 3, 9, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 21, 0, 0, 0, DateTimeKind.Unspecified) }
                        },
                        new
                        {
                            VendorID = "2",
                            Fri = new[] { new DateTime(2021, 3, 9, 5, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                            Location = "15 D5 St., Ward 25, Binh Thanh District, HCMC",
                            Mon = new[] { new DateTime(2021, 3, 9, 5, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                            Sat = new[] { new DateTime(2021, 3, 9, 5, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                            Tue = new[] { new DateTime(2021, 3, 9, 5, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                            Wed = new[] { new DateTime(2021, 3, 9, 5, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 11, 0, 0, 0, DateTimeKind.Unspecified) }
                        },
                        new
                        {
                            VendorID = "3",
                            Fri = new[] { new DateTime(2021, 3, 9, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                            Location = "10-12 Dinh Tien Hoang St., Ben Nghe Ward, District 1, HCMC",
                            Mon = new[] { new DateTime(2021, 3, 9, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                            Tue = new[] { new DateTime(2021, 3, 9, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                            Wed = new[] { new DateTime(2021, 3, 9, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 12, 0, 0, 0, DateTimeKind.Unspecified) }
                        },
                        new
                        {
                            VendorID = "4",
                            Fri = new[] { new DateTime(2021, 3, 9, 6, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                            Location = "217 Hong Bang, Ward 1, District 5, HCMC",
                            Mon = new[] { new DateTime(2021, 3, 9, 6, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                            Tue = new[] { new DateTime(2021, 3, 9, 6, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                            Wed = new[] { new DateTime(2021, 3, 9, 6, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 8, 0, 0, 0, DateTimeKind.Unspecified) }
                        },
                        new
                        {
                            VendorID = "5",
                            Location = "82 Vinh Vien, Ward 2, District 10, HCMC",
                            Sat = new[] { new DateTime(2021, 3, 9, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 22, 0, 0, 0, DateTimeKind.Unspecified) },
                            Sun = new[] { new DateTime(2021, 3, 9, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 22, 0, 0, 0, DateTimeKind.Unspecified) }
                        },
                        new
                        {
                            VendorID = "6",
                            Location = "138 Nguyen Trai, Ward 3, District 5",
                            Sat = new[] { new DateTime(2021, 3, 9, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 11, 59, 0, 0, DateTimeKind.Unspecified) },
                            Sun = new[] { new DateTime(2021, 3, 9, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 23, 59, 0, 0, DateTimeKind.Unspecified) }
                        },
                        new
                        {
                            VendorID = "7",
                            Location = "267 Pham Van Chi, Ward 3, District 6",
                            Sat = new[] { new DateTime(2021, 3, 9, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 21, 0, 0, 0, DateTimeKind.Unspecified) },
                            Sun = new[] { new DateTime(2021, 3, 9, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 21, 0, 0, 0, DateTimeKind.Unspecified) }
                        },
                        new
                        {
                            VendorID = "8",
                            Location = "8 Phan Van Han, Ward 19, Binh Thanh District",
                            Sat = new[] { new DateTime(2021, 3, 9, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 23, 59, 0, 0, DateTimeKind.Unspecified) },
                            Sun = new[] { new DateTime(2021, 3, 9, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 23, 59, 0, 0, DateTimeKind.Unspecified) }
                        },
                        new
                        {
                            VendorID = "9",
                            Location = "27 Thanh Da, Ward 27, Binh Thanh District",
                            Sat = new[] { new DateTime(2021, 3, 9, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 22, 0, 0, 0, DateTimeKind.Unspecified) },
                            Sun = new[] { new DateTime(2021, 3, 9, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 22, 0, 0, 0, DateTimeKind.Unspecified) }
                        },
                        new
                        {
                            VendorID = "10",
                            Location = "623/20 CMT8, P.15, Q.10",
                            Sat = new[] { new DateTime(2021, 3, 9, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 22, 0, 0, 0, DateTimeKind.Unspecified) },
                            Sun = new[] { new DateTime(2021, 3, 9, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 22, 0, 0, 0, DateTimeKind.Unspecified) }
                        },
                        new
                        {
                            VendorID = "11",
                            Location = "897/29 Tran Hung Dao, Ward 01, District 5, HCMC",
                            Sat = new[] { new DateTime(2021, 3, 9, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                            Sun = new[] { new DateTime(2021, 3, 9, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 17, 0, 0, 0, DateTimeKind.Unspecified) }
                        },
                        new
                        {
                            VendorID = "12",
                            Location = "246/55A Hoa Hung, Ward 13, District 10",
                            Sat = new[] { new DateTime(2021, 3, 9, 6, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 21, 0, 0, 0, DateTimeKind.Unspecified) },
                            Sun = new[] { new DateTime(2021, 3, 9, 6, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 21, 0, 0, 0, DateTimeKind.Unspecified) }
                        },
                        new
                        {
                            VendorID = "13",
                            Location = "48 Kha Van Can St., Binh Chanh Ward, Thu Duc District",
                            Sat = new[] { new DateTime(2021, 3, 9, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 22, 0, 0, 0, DateTimeKind.Unspecified) },
                            Sun = new[] { new DateTime(2021, 3, 9, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 22, 0, 0, 0, DateTimeKind.Unspecified) }
                        },
                        new
                        {
                            VendorID = "14",
                            Location = "Le Van Tam Park",
                            Sat = new[] { new DateTime(2021, 3, 9, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 22, 0, 0, 0, DateTimeKind.Unspecified) },
                            Sun = new[] { new DateTime(2021, 3, 9, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 22, 0, 0, 0, DateTimeKind.Unspecified) }
                        },
                        new
                        {
                            VendorID = "15",
                            Location = "38 Phạm Ngọc Thạch, P.6, Q.3, HCM",
                            Sat = new[] { new DateTime(2021, 3, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 23, 0, 0, 0, DateTimeKind.Unspecified) },
                            Sun = new[] { new DateTime(2021, 3, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 23, 0, 0, 0, DateTimeKind.Unspecified) }
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
