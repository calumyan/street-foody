using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace street_foody.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        public DbSet<StreetVendor> StreetVendor { get; set; }
        public DbSet<Food> Food { get; set; }
        public DbSet<FoodCategory> FoodCategory { get; set; }
        public DbSet<VendorHours> VendorHours { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /// <summary> AverageRating is used as part of the ViewModel, not the Entity model.modelBuilder.Entity<StreetVendor>().Ignore(v => v.AverageRating); 
            ///</summary>

            modelBuilder.Entity<StreetVendor>().HasData(
              new StreetVendor
              {
                  VendorID = "1",
                  VietnameseName = "Hủ tiếu Trần Bình Trọng",
                  EnglishName = "Tran Binh Trong rice noodles",
                  RatingList = new int[] { 4, 4, 4 },
                  PriceRange = new int[] { 15000, 30000 },
                  PhotoUrl = "https://static.riviu.co/640/image/2020/09/04/bef16221de75b45fea2dd579b5c9a29a_output.jpeg"
              },
              new StreetVendor
              {
                  VendorID = "2",
                  VietnameseName = "Bánh mì Dì Loan",
                  EnglishName = "Aunty Loan's banh mi",
                  RatingList = new int[] { 5 },
                  PriceRange = new int[] { 15000, 20000 }
              },
              new StreetVendor
              {
                  VendorID = "3",
                  VietnameseName = "Miến xào",
                  EnglishName = "Miến xào",
                  RatingList = new int[] { 5 },
                  PriceRange = new int[] { 10000, 15000 }
              },
              new StreetVendor
              {
                  VendorID = "4",
                  VietnameseName = "Xôi",
                  EnglishName = "Sticky rice",
                  RatingList = new int[] { 3 },
                  PriceRange = new int[] { 10000, 15000 }
              },
              new StreetVendor
              {
                  VendorID = "5",
                  VietnameseName = "Ăn vặt,trà sữa đường Vĩnh Viễn",
                  EnglishName = "Vinh Vien St. snacks and boba tea",
                  RatingList = new int[] { },
                  PriceRange = new int[] { 14000, 29000 },
                  PhotoUrl = "https://scontent.ffcm1-2.fna.fbcdn.net/v/t1.0-9/156646575_817247045527459_8464517707157016028_n.jpg?_nc_cat=1&ccb=3&_nc_sid=b9115d&_nc_ohc=7qGQxbPz5GIAX94w5F1&_nc_ht=scontent.ffcm1-2.fna&oh=66f3c0a1330121b1100836f404c5ced8&oe=60685917"
              },
              new StreetVendor
              {
                  VendorID = "6",
                  VietnameseName = "Bún bò Bàu Sen",
                  EnglishName = "Bau Sen market beef vermicelli soup",
                  RatingList = new int[] { 5 },
                  PriceRange = new int[] { 35000, 45000 },
                  PhotoUrl = "https://scontent.ffcm1-2.fna.fbcdn.net/v/t1.0-9/84698123_1286864361515233_6961019376854106112_n.jpg?_nc_cat=108&ccb=3&_nc_sid=730e14&_nc_ohc=E1KHA4sGlc4AX_ZY4Mn&_nc_ht=scontent.ffcm1-2.fna&oh=8a56d06173f2342f91f7da037f89fff0&oe=60666BCB"
              },
              new StreetVendor
              {
                  VendorID = "7",
                  VietnameseName = "Trà sữa Anva",
                  EnglishName = "Anva boba tea",
                  PriceRange = new int[] { 99999999, 99999999 },
                  PhotoUrl = "https://scontent.ffcm1-2.fna.fbcdn.net/v/t1.0-9/155165695_240195354407050_2744091707808776661_n.jpg?_nc_cat=101&ccb=3&_nc_sid=8bfeb9&_nc_ohc=05vpqk1kzbAAX9TFzD4&_nc_ht=scontent.ffcm1-2.fna&oh=6b0b19a21677cc60dc3c605d0746e109&oe=606906E4"
              },
              new StreetVendor
              {
                  VendorID = "8",
                  VietnameseName = "Xôi ngọt chị Ú",
                  EnglishName = "Chubby sis's sweet sticky rice",
                  PriceRange = new int[] { 20000, 25000 },
                  PhotoUrl = "https://scontent.ffcm1-2.fna.fbcdn.net/v/t1.0-9/155122691_1246898299037777_4391716006726234458_n.jpg?_nc_cat=107&ccb=3&_nc_sid=b9115d&_nc_ohc=Oh-3nRYX_ywAX_XtP7F&_nc_ht=scontent.ffcm1-2.fna&oh=6d0ae3ea925ae24e6cc4fefe7eb8f5ec&oe=606915A1"
              },
              new StreetVendor
              {
                  VendorID = "9",
                  VietnameseName = "Tiger Tea",
                  EnglishName = "Tiger Tea",
                  RatingList = new int[] { 5 },
                  PriceRange = new int[] { 15000, 40000 },
                  PhotoUrl = "https://scontent.ffcm1-1.fna.fbcdn.net/v/t1.0-9/155512636_546860506277469_3968119529767571609_o.jpg?_nc_cat=109&ccb=3&_nc_sid=b9115d&_nc_ohc=a11O8kknWEQAX-WDDGL&_nc_ht=scontent.ffcm1-1.fna&oh=2bb5aef40ca9ab14683c771ff074e599&oe=6066F325"
              },
              new StreetVendor
              {
                  VendorID = "10",
                  VietnameseName = "Bánh tráng Bà Ngoại",
                  EnglishName = "Grandma's rice paper mix",
                  RatingList = new int[] { 5, 5, 5, 4 },
                  PriceRange = new int[] { 15000, 50000 },
                  PhotoUrl = "https://static.riviu.co/960/image/2021/01/23/507d435341a6bf9a8b78f73b2498cff8_output.jpeg"
              },
              new StreetVendor
              {
                  VendorID = "11",
                  VietnameseName = "Chè cô Thủy",
                  EnglishName = "Aunty Thuy's sweet gruel",
                  RatingList = new int[] { 5, 5, 5, 5 },
                  PriceRange = new int[] { 10000, 50000 },
                  PhotoUrl = "https://cdn01.diadiemanuong.com/ddau/999x/undefined-che-co-thuy-cao-dat-0-56b16e9637305080834967437.jpg"
              },
              new StreetVendor
              {
                  VendorID = "12",
                  VietnameseName = "Bánh mì Bà Nội",
                  EnglishName = "Grandma's banh mi",
                  RatingList = new int[] { 4 },
                  PriceRange = new int[] { 20000, 25000 },
                  PhotoUrl = "https://static.riviu.co/960/image/2020/06/15/f38acd6e2f5fa2c9e3529702ddc1f588_output.jpeg"
              },
              new StreetVendor
              {
                  VendorID = "13",
                  VietnameseName = "Hủ tiếu gõ 20k",
                  EnglishName = "Hu tieu go 20k",
                  RatingList = new int[] { 5 },
                  PriceRange = new int[] { 15000, 20000 },
                  PhotoUrl = "https://static.riviu.co/960/image/2020/11/23/60cc5128a4dae43cef57378f30e688c0_output.jpeg"
              },
              new StreetVendor
              {
                  VendorID = "14",
                  VietnameseName = "Bò bía 2 ông chú",
                  EnglishName = "2 uncles' popiah",
                  RatingList = new int[] { 5 },
                  PriceRange = new int[] { 30000, 45000 },
                  PhotoUrl = "https://static.riviu.co/960/image/2020/12/28/e02c4fae62a8993c43996561df2865a4_output.jpeg",
              },
              new StreetVendor
              {
                  VendorID = "15",
                  VietnameseName = "Green Box (Gibi)",
                  EnglishName = "Green Box (Gibi)",
                  RatingList = new int[] { 3, 4, 4 },
                  PriceRange = new int[] { 5000, 40000 },
                  PhotoUrl = "https://static.riviu.co/960/image/2020/12/04/67fabbc325dd84ba17fdc0e6e63978e9_output.jpeg"
              }
            );

            modelBuilder.Entity<VendorHours>(
                    entity =>
                    {
                        entity.HasOne(h => h.Vendor)
                            .WithMany(v => v.VendorHours)
                            .HasForeignKey("VendorID");
                    });

            modelBuilder.Entity<VendorHours>().HasData(
              new VendorHours
              {
                  VendorHoursID = "1",
                  VendorID = "1",
                  Location = "359 Tran Binh Trong, Ward 1, District 10, HCMC",
                  Sun = new System.DateTime[] { System.DateTime.Parse("03:00 PM"), System.DateTime.Parse("09:00 PM") },
                  Sat = new System.DateTime[] { System.DateTime.Parse("03:00 PM"), System.DateTime.Parse("09:00 PM") }
              },
              new VendorHours
              {
                  VendorHoursID = "2",
                  VendorID = "2",
                  Location = "15 D5 St., Ward 25, Binh Thanh District, HCMC",
                  Mon = new System.DateTime[] { System.DateTime.Parse("05:00 AM"), System.DateTime.Parse("11:00 AM") },
                  Tue = new System.DateTime[] { System.DateTime.Parse("05:00 AM"), System.DateTime.Parse("11:00 AM") },
                  Wed = new System.DateTime[] { System.DateTime.Parse("05:00 AM"), System.DateTime.Parse("11:00 AM") },
                  Fri = new System.DateTime[] { System.DateTime.Parse("05:00 AM"), System.DateTime.Parse("11:00 AM") },
                  Sat = new System.DateTime[] { System.DateTime.Parse("05:00 AM"), System.DateTime.Parse("11:00 AM") }
              },
              new VendorHours
              {
                  VendorHoursID = "3",
                  VendorID = "3",
                  Location = "10-12 Dinh Tien Hoang St., Ben Nghe Ward, District 1, HCMC",
                  Mon = new System.DateTime[] { System.DateTime.Parse("10:00 AM"), System.DateTime.Parse("12:00 PM") },
                  Tue = new System.DateTime[] { System.DateTime.Parse("10:00 AM"), System.DateTime.Parse("12:00 PM") },
                  Wed = new System.DateTime[] { System.DateTime.Parse("10:00 AM"), System.DateTime.Parse("12:00 PM") },
                  Fri = new System.DateTime[] { System.DateTime.Parse("10:00 AM"), System.DateTime.Parse("12:00 PM") }
              },
              new VendorHours
              {
                  VendorHoursID = "4",
                  VendorID = "4",
                  Location = "217 Hong Bang, Ward 1, District 5, HCMC",
                  Mon = new System.DateTime[] { System.DateTime.Parse("06:00 AM"), System.DateTime.Parse("08:00 AM") },
                  Tue = new System.DateTime[] { System.DateTime.Parse("06:00 AM"), System.DateTime.Parse("08:00 AM") },
                  Wed = new System.DateTime[] { System.DateTime.Parse("06:00 AM"), System.DateTime.Parse("08:00 AM") },
                  Fri = new System.DateTime[] { System.DateTime.Parse("06:00 AM"), System.DateTime.Parse("08:00 AM") }
              },
              new VendorHours
              {
                  VendorHoursID = "5",
                  VendorID = "5",
                  Location = "82 Vinh Vien, Ward 2, District 10, HCMC",
                  Sun = new System.DateTime[] { System.DateTime.Parse("09:00 AM"), System.DateTime.Parse("10:00 PM") },
                  Mon = new System.DateTime[] { System.DateTime.Parse("09:00 AM"), System.DateTime.Parse("10:00 PM") },
                  Tue = new System.DateTime[] { System.DateTime.Parse("09:00 AM"), System.DateTime.Parse("10:00 PM") },
                  Wed = new System.DateTime[] { System.DateTime.Parse("09:00 AM"), System.DateTime.Parse("10:00 PM") },
                  Thu = new System.DateTime[] { System.DateTime.Parse("09:00 AM"), System.DateTime.Parse("10:00 PM") },
                  Fri = new System.DateTime[] { System.DateTime.Parse("09:00 AM"), System.DateTime.Parse("10:00 PM") },
                  Sat = new System.DateTime[] { System.DateTime.Parse("09:00 AM"), System.DateTime.Parse("10:00 PM") }
              },
              new VendorHours
              {
                  VendorHoursID = "6",
                  VendorID = "6",
                  Location = "138 Nguyen Trai, Ward 3, District 5",
                  Sun = new System.DateTime[] { System.DateTime.Parse("05:00 PM"), System.DateTime.Parse("11:59 PM") },
                  Mon = new System.DateTime[] { System.DateTime.Parse("05:00 PM"), System.DateTime.Parse("11:59 PM") },
                  Tue = new System.DateTime[] { System.DateTime.Parse("05:00 PM"), System.DateTime.Parse("11:59 PM") },
                  Wed = new System.DateTime[] { System.DateTime.Parse("05:00 PM"), System.DateTime.Parse("11:59 PM") },
                  Thu = new System.DateTime[] { System.DateTime.Parse("05:00 PM"), System.DateTime.Parse("11:59 PM") },
                  Fri = new System.DateTime[] { System.DateTime.Parse("05:00 PM"), System.DateTime.Parse("11:59 PM") },
                  Sat = new System.DateTime[] { System.DateTime.Parse("05:00 PM"), System.DateTime.Parse("11:59 AM") }
              },
              new VendorHours
              {
                  VendorHoursID = "7",
                  VendorID = "7",
                  Location = "267 Pham Van Chi, Ward 3, District 6",
                  Sun = new System.DateTime[] { System.DateTime.Parse("11:00 AM"), System.DateTime.Parse("09:00 PM") },
                  Mon = new System.DateTime[] { System.DateTime.Parse("11:00 AM"), System.DateTime.Parse("09:00 PM") },
                  Tue = new System.DateTime[] { System.DateTime.Parse("11:00 AM"), System.DateTime.Parse("09:00 PM") },
                  Wed = new System.DateTime[] { System.DateTime.Parse("11:00 AM"), System.DateTime.Parse("09:00 PM") },
                  Thu = new System.DateTime[] { System.DateTime.Parse("11:00 AM"), System.DateTime.Parse("09:00 PM") },
                  Fri = new System.DateTime[] { System.DateTime.Parse("11:00 AM"), System.DateTime.Parse("09:00 PM") },
                  Sat = new System.DateTime[] { System.DateTime.Parse("11:00 AM"), System.DateTime.Parse("09:00 PM") }
              },
              new VendorHours
              {
                  VendorHoursID = "8",
                  VendorID = "8",
                  Location = "8 Phan Van Han, Ward 19, Binh Thanh District",
                  Sun = new System.DateTime[] { System.DateTime.Parse("03:00 PM"), System.DateTime.Parse("11:59 PM") },
                  Sat = new System.DateTime[] { System.DateTime.Parse("03:00 PM"), System.DateTime.Parse("11:59 PM") }
              },
              new VendorHours
              {
                  VendorHoursID = "9",
                  VendorID = "9",
                  Location = "27 Thanh Da, Ward 27, Binh Thanh District",
                  Sun = new System.DateTime[] { System.DateTime.Parse("06:00 PM"), System.DateTime.Parse("10:00 PM") },
                  Mon = new System.DateTime[] { System.DateTime.Parse("06:00 PM"), System.DateTime.Parse("10:00 PM") },
                  Tue = new System.DateTime[] { System.DateTime.Parse("06:00 PM"), System.DateTime.Parse("10:00 PM") },
                  Wed = new System.DateTime[] { System.DateTime.Parse("06:00 PM"), System.DateTime.Parse("10:00 PM") },
                  Thu = new System.DateTime[] { System.DateTime.Parse("06:00 PM"), System.DateTime.Parse("10:00 PM") },
                  Fri = new System.DateTime[] { System.DateTime.Parse("06:00 PM"), System.DateTime.Parse("10:00 PM") },
                  Sat = new System.DateTime[] { System.DateTime.Parse("06:00 PM"), System.DateTime.Parse("10:00 PM") }
              },
              new VendorHours
              {
                  VendorHoursID = "10",
                  VendorID = "10",
                  Location = "623/20 CMT8, P.15, Q.10",
                  Sun = new System.DateTime[] { System.DateTime.Parse("05:30 PM"), System.DateTime.Parse("10:00 PM") },
                  Mon = new System.DateTime[] { System.DateTime.Parse("05:30 PM"), System.DateTime.Parse("10:00 PM") },
                  Tue = new System.DateTime[] { System.DateTime.Parse("05:30 PM"), System.DateTime.Parse("10:00 PM") },
                  Wed = new System.DateTime[] { System.DateTime.Parse("05:30 PM"), System.DateTime.Parse("10:00 PM") },
                  Thu = new System.DateTime[] { System.DateTime.Parse("05:30 PM"), System.DateTime.Parse("10:00 PM") },
                  Fri = new System.DateTime[] { System.DateTime.Parse("05:30 PM"), System.DateTime.Parse("10:00 PM") },
                  Sat = new System.DateTime[] { System.DateTime.Parse("05:30 PM"), System.DateTime.Parse("10:00 PM") }
              },
              new VendorHours
              {
                  VendorHoursID = "11",
                  VendorID = "11",
                  Location = "897/29 Tran Hung Dao, Ward 01, District 5, HCMC",
                  Sun = new System.DateTime[] { System.DateTime.Parse("11:00 AM"), System.DateTime.Parse("05:00 PM") },
                  Mon = new System.DateTime[] { System.DateTime.Parse("11:00 AM"), System.DateTime.Parse("05:00 PM") },
                  Tue = new System.DateTime[] { System.DateTime.Parse("11:00 AM"), System.DateTime.Parse("05:00 PM") },
                  Wed = new System.DateTime[] { System.DateTime.Parse("11:00 AM"), System.DateTime.Parse("05:00 PM") },
                  Thu = new System.DateTime[] { System.DateTime.Parse("11:00 AM"), System.DateTime.Parse("05:00 PM") },
                  Fri = new System.DateTime[] { System.DateTime.Parse("11:00 AM"), System.DateTime.Parse("05:00 PM") },
                  Sat = new System.DateTime[] { System.DateTime.Parse("11:00 AM"), System.DateTime.Parse("05:00 PM") }
              },
              new VendorHours
              {
                  VendorHoursID = "12",
                  VendorID = "12",
                  Location = "246/55A Hoa Hung, Ward 13, District 10",
                  Sun = new System.DateTime[] { System.DateTime.Parse("06:00 AM"), System.DateTime.Parse("09:00 PM") },
                  Mon = new System.DateTime[] { System.DateTime.Parse("06:00 AM"), System.DateTime.Parse("09:00 PM") },
                  Tue = new System.DateTime[] { System.DateTime.Parse("06:00 AM"), System.DateTime.Parse("09:00 PM") },
                  Wed = new System.DateTime[] { System.DateTime.Parse("06:00 AM"), System.DateTime.Parse("09:00 PM") },
                  Thu = new System.DateTime[] { System.DateTime.Parse("06:00 AM"), System.DateTime.Parse("09:00 PM") },
                  Fri = new System.DateTime[] { System.DateTime.Parse("06:00 AM"), System.DateTime.Parse("09:00 PM") },
                  Sat = new System.DateTime[] { System.DateTime.Parse("06:00 AM"), System.DateTime.Parse("09:00 PM") }
              },
              new VendorHours
              {
                  VendorHoursID = "13",
                  VendorID = "13",
                  Location = "48 Kha Van Can St., Binh Chanh Ward, Thu Duc District",
                  Sun = new System.DateTime[] { System.DateTime.Parse("06:00 PM"), System.DateTime.Parse("10:00 PM") },
                  Mon = new System.DateTime[] { System.DateTime.Parse("06:00 PM"), System.DateTime.Parse("10:00 PM") },
                  Tue = new System.DateTime[] { System.DateTime.Parse("06:00 PM"), System.DateTime.Parse("10:00 PM") },
                  Wed = new System.DateTime[] { System.DateTime.Parse("06:00 PM"), System.DateTime.Parse("10:00 PM") },
                  Thu = new System.DateTime[] { System.DateTime.Parse("06:00 PM"), System.DateTime.Parse("10:00 PM") },
                  Fri = new System.DateTime[] { System.DateTime.Parse("06:00 PM"), System.DateTime.Parse("10:00 PM") },
                  Sat = new System.DateTime[] { System.DateTime.Parse("06:00 PM"), System.DateTime.Parse("10:00 PM") }
              },
              new VendorHours
              {
                  VendorHoursID = "14",
                  VendorID = "14",
                  Location = "Le Van Tam Park",
                  Sun = new System.DateTime[] { System.DateTime.Parse("05:00 PM"), System.DateTime.Parse("10:00 PM") },
                  Mon = new System.DateTime[] { System.DateTime.Parse("05:00 PM"), System.DateTime.Parse("10:00 PM") },
                  Tue = new System.DateTime[] { System.DateTime.Parse("05:00 PM"), System.DateTime.Parse("10:00 PM") },
                  Wed = new System.DateTime[] { System.DateTime.Parse("05:00 PM"), System.DateTime.Parse("10:00 PM") },
                  Thu = new System.DateTime[] { System.DateTime.Parse("05:00 PM"), System.DateTime.Parse("10:00 PM") },
                  Fri = new System.DateTime[] { System.DateTime.Parse("05:00 PM"), System.DateTime.Parse("10:00 PM") },
                  Sat = new System.DateTime[] { System.DateTime.Parse("05:00 PM"), System.DateTime.Parse("10:00 PM") }
              },
              new VendorHours
              {
                  VendorHoursID = "15",
                  VendorID = "15",
                  Location = "38 Phạm Ngọc Thạch, P.6, Q.3, HCMC",
                  Sun = new System.DateTime[] { System.DateTime.Parse("12:00 PM"), System.DateTime.Parse("11:00 PM") },
                  Mon = new System.DateTime[] { System.DateTime.Parse("12:00 PM"), System.DateTime.Parse("11:00 PM") },
                  Tue = new System.DateTime[] { System.DateTime.Parse("12:00 PM"), System.DateTime.Parse("11:00 PM") },
                  Wed = new System.DateTime[] { System.DateTime.Parse("12:00 PM"), System.DateTime.Parse("11:00 PM") },
                  Thu = new System.DateTime[] { System.DateTime.Parse("12:00 PM"), System.DateTime.Parse("11:00 PM") },
                  Fri = new System.DateTime[] { System.DateTime.Parse("12:00 PM"), System.DateTime.Parse("11:00 PM") },
                  Sat = new System.DateTime[] { System.DateTime.Parse("12:00 PM"), System.DateTime.Parse("11:00 PM") }
              }
            );



            modelBuilder.Entity<FoodCategory>().HasData(
              new FoodCategory
              {
                  FoodCategoryID = "1",
                  VietnameseName = "Phở",
                  EnglishName = "Pho",
                  Description = "A soup with rice noodles, herbs, and meat. Pho in Saigon tends to have a clearer broth, and can include bean sprouts, fresh sliced chili, hoisin sauce, and additional herbs. Pho is considered to be Vietnam's national dish."
              },
            new FoodCategory
            {
                FoodCategoryID = "2",
                VietnameseName = "Hủ tiếu",
                EnglishName = "Rice noodles, or simply hu tieu",
                Description = "This noodle dish can be served with or without broth (dry) and includes pork bones, herbs, and a variety of meats and other ingredients."
            },
            new FoodCategory
            {
                FoodCategoryID = "3",
                VietnameseName = "Mì",
                EnglishName = "Egg noodles",
                Description = "Noodles made out of wheat flour or egg noodles. These noodles can be thick or thin, and can be served in soups or dry (without broth)."
            },
            new FoodCategory
            {
                FoodCategoryID = "4",
                VietnameseName = "Bún",
                EnglishName = "Vietnamese rice vermicelli",
                Description = "These thin rice noodles, also known as rice vermicelli, can be found in soups, served with meats and vegetables, or in goi cuon."
            },
            new FoodCategory
            {
                FoodCategoryID = "5",
                VietnameseName = "Bánh canh",
                EnglishName = "Tapioca noodles, banh canh",
                Description = "Thick tapioca noodles that can be served with a variety of broths and toppings, which can include crab, fish cakes, pork, and more."
            },
            new FoodCategory
            {
                FoodCategoryID = "6",
                VietnameseName = "Miến",
                EnglishName = "Cellophane noodles, glass noodles",
                Description = "Also known as cellophane or glass noodles, these help make up Vietnamese dishes like mien ga, a chicken soup. Often confused with bun, or rice vermicelli, glass noodles can be distinguished by their clear glass-like appearance when cooked."
            },
            new FoodCategory
            {
                FoodCategoryID = "7",
                VietnameseName = "Nui",
                EnglishName = "Vietnamese macaroni",
                Description = "These noodles are Vietnamese macaroni, and are often included in Vietnamese chicken and noodle soups."
            },
            new FoodCategory
            {
                FoodCategoryID = "8",
                VietnameseName = "Bánh cuốn",
                EnglishName = "Steamed rice rolls, Rice noodle rolls",
                Description = "Rice noodle rolls made from thin sheets of fermented rice that are steamed and filled with pork, mushrooms, and shallots."
            },
            new FoodCategory
            {
                FoodCategoryID = "9",
                VietnameseName = "Cơm tấm",
                EnglishName = "Vietnamese broken rice",
                Description = "This dish is made from broken rice grains, and is quite popular in Saigon. It often includes grilled pork ribs, fried egg, scallions, fresh and pickled vegetables, and fish sauce."
            },
            new FoodCategory
            {
                FoodCategoryID = "10",
                VietnameseName = "Cháo",
                EnglishName = "Congee",
                Description = "Vietnamese congee, or rice porridge. It can be combined with chicken, duck, or pork and broth, as well as vegetables, and can also be served with youtiao (a type of fried dough)."
            },
            new FoodCategory
            {
                FoodCategoryID = "11",
                VietnameseName = "Súp",
                EnglishName = "Egg drop soup",
                Description = "A type of thick, chunky soup made from flavored soup base, egg and tapioca starch. Other typical ingredients include quail eggs, crab meat, pig brain, mushrooms and vegetables. In English, known as egg drop soup."
            },
            new FoodCategory
            {
                FoodCategoryID = "12",
                VietnameseName = "Xôi",
                EnglishName = "Sticky rice",
                Description = ""
            },
            new FoodCategory
            {
                FoodCategoryID = "13",
                VietnameseName = "Bánh mì",
                EnglishName = "Vietnamese sandwich",
                Description = "A sandwich made with a short baguette that often includes pork, cucumber, pickled carrots, cilantro, chili, and mayonnaise, or a wide variety of other ingredients and combinations."
            },
            new FoodCategory
            {
                FoodCategoryID = "14",
                VietnameseName = "Bánh bao",
                EnglishName = "Vietnamese steamed bun",
                Description = "A round savory bun filled with meat, eggs, and vegetables including onions and mushrooms. Often include Chinese sausage and hard-boiled egg."
            },
            new FoodCategory
            {
                FoodCategoryID = "15",
                VietnameseName = "Điểm sấm",
                EnglishName = "Dim sum",
                Description = "Originally from China, these can include wontons, dumplings and poststickers and other ball/bun shaped dishes eaten with or without soup. Generally, they are meat balls wrapped inside flour wrappers."
            },
            new FoodCategory
            {
                FoodCategoryID = "16",
                VietnameseName = "Cuốn",
                EnglishName = "Rolls",
                Description = "Any Vietnamese traditional food that comes in the form of rolls, e.g. summer rolls, egg rolls, bo bia, .... Wrappers are commonly made from rice papers or betel leaves."
            },
            new FoodCategory
            {
                FoodCategoryID = "17",
                VietnameseName = "Pancakes",
                EnglishName = "Crispy pancakes",
                Description = "These crispy, savory pancakes are made of rice flour, water, and turmeric, fried in a pan and filled with ingredients like pork, prawns, green onion, mung bean, and herbs."
            },
            new FoodCategory
            {
                FoodCategoryID = "18",
                VietnameseName = "Bánh tráng",
                EnglishName = "Rice paper",
                Description = "Rice paper wrappers made from a mixture of rice flour with tapioca starch, water and salt. They are thin and light in texture, and often used in egg rolls and spring rolls."
            },
            new FoodCategory
            {
                FoodCategoryID = "19",
                VietnameseName = "Trứng",
                EnglishName = "Eggs",
                Description = "Eggs (usually from a quail, a duck or a chicken), often boiled and fertilized, or soft-boiled."
            },
            new FoodCategory
            {
                FoodCategoryID = "20",
                VietnameseName = "Bánh ngọt",
                EnglishName = "Sweet cakes",
                Description = "Sweet cakes are a type of Vietnamese dessert and come in many varieties. Cakes can often include rice flour and coconut milk, and can feature flavors like banana and cassava, among others."
            },
            new FoodCategory
            {
                FoodCategoryID = "21",
                VietnameseName = "Xiên que",
                EnglishName = "Skewers",
                Description = "Skewered food in Vietnam can include fried fish balls, grilled corn, grilled sausage, and more."
            },
            new FoodCategory
            {
                FoodCategoryID = "22",
                VietnameseName = "Trái cây",
                EnglishName = "Fruits",
                Description = ""
            },
            new FoodCategory
            {
                FoodCategoryID = "23",
                VietnameseName = "Chè",
                EnglishName = "Sweet gruel",
                Description = "Sweet gruel is another Vietnamese dessert, with textures ranging from that of a soup to a pudding. Flavors vary, including fruits and chocolates, and often include coconut milk, rice, and/or tapioca."
            },
            new FoodCategory
            {
                FoodCategoryID = "24",
                VietnameseName = "Nước ép",
                EnglishName = "Juice",
                Description = ""
            },
            new FoodCategory
            {
                FoodCategoryID = "25",
                VietnameseName = "Nước đóng chai",
                EnglishName = "Bottled drinks",
                Description = ""
            },
            new FoodCategory
            {
                FoodCategoryID = "26",
                VietnameseName = "Trà",
                EnglishName = "Tea",
                Description = ""
            },
            new FoodCategory
            {
                FoodCategoryID = "27",
                VietnameseName = "Cà phê",
                EnglishName = "Vietnamese coffee",
                Description = ""
            },
            new FoodCategory
            {
                FoodCategoryID = "28",
                VietnameseName = "Trà sữa",
                EnglishName = "Boba tea",
                Description = ""
            },
            new FoodCategory
            {
                FoodCategoryID = "29",
                VietnameseName = "Tráng miệng",
                EnglishName = "Dessert",
                Description = ""
            },
            new FoodCategory
            {
                FoodCategoryID = "30",
                VietnameseName = "Other",
                EnglishName = "Other",
                Description = ""
            }


            );

            modelBuilder.Entity<Food>(
                    entity =>
                    {
                        entity.HasOne(f => f.Vendor)
                            .WithMany(v => v.Foods)
                            .HasForeignKey("VendorID");
                    });

            modelBuilder.Entity<Food>(
                    entity =>
                    {
                        entity.HasOne(d => d.FoodCategory)
                            .WithMany(p => p.Foods)
                            .HasForeignKey("FoodCategoryID");
                    });


            modelBuilder.Entity<Food>().HasData(
              new Food
              {
                  FoodID = "1",
                  VietnameseName = "Hủ tiếu thập cẩm",
                  EnglishName = "Mixed rice noodle soup",
                  Price = 25000,
                  VendorID = "1",
                  FoodCategoryID = "2"

              },
              new Food
              {
                  FoodID = "2",
                  VietnameseName = "Bánh mì thịt nguội",
                  EnglishName = "Cold cut",
                  Price = 15000,
                  VendorID = "2",
                  FoodCategoryID = "13"
              },
              new Food
              {
                  FoodID = "3",
                  VietnameseName = "Miến",
                  EnglishName = "Mixed stir-fried glass noodles",
                  Price = 10000,
                  VendorID = "3",
                  FoodCategoryID = "6"
              },
              new Food
              {
                  FoodID = "4",
                  VietnameseName = "Bún",
                  EnglishName = "Rice vermicelli",
                  Price = 10000,
                  VendorID = "3",
                  FoodCategoryID = "4"
              },
              new Food
              {
                  FoodID = "5",
                  VietnameseName = "Nui xào thập cẩm",
                  EnglishName = "Vietnamese macaroni",
                  Price = 10000,
                  VendorID = "3",
                  FoodCategoryID = "7"
              },
              new Food
              {
                  FoodID = "6",
                  VietnameseName = "Thêm miến",
                  EnglishName = "Additional mixed stir-fried glass noodles",
                  Price = 3000,
                  VendorID = "3",
                  FoodCategoryID = "6"
              },
              new Food
              {
                  FoodID = "7",
                  VietnameseName = "Thêm Bún",
                  EnglishName = "Additional rice vermicelli",
                  Price = 3000,
                  VendorID = "3",
                  FoodCategoryID = "4"
              },
              new Food
              {
                  FoodID = "8",
                  VietnameseName = "Thêm nui xào thập cẩm",
                  EnglishName = "Additional Vietnamese macaroni",
                  Price = 3000,
                  VendorID = "3",
                  FoodCategoryID = "7"
              },
              new Food
              {
                  FoodID = "9",
                  VietnameseName = "Xôi mặn - size vừa",
                  EnglishName = "Savory sticky rice - medium",
                  Price = 10000,
                  VendorID = "4",
                  FoodCategoryID = "12"
              },
              new Food
              {
                  FoodID = "34",
                  VietnameseName = "Xôi mặn - size lớn",
                  EnglishName = "Savory sticky rice - large",
                  Price = 15000,
                  VendorID = "4",
                  FoodCategoryID = "12"
              },
              new Food
              {
                  FoodID = "10",
                  VietnameseName = "Trà sữa",
                  EnglishName = "Boba tea",
                  Price = 20000,
                  VendorID = "5",
                  FoodCategoryID = "28"
              },
              new Food
              {
                  FoodID = "11",
                  VietnameseName = "Trúng cút lòng đào (10 trứng)",
                  EnglishName = "Soft-boiled quail eggs (10ct)",
                  Price = 15000,
                  VendorID = "5",
                  FoodCategoryID = "19"
              },
              new Food
              {
                  FoodID = "12",
                  VietnameseName = "Trứng gà lòng đào (2 trứng)",
                  EnglishName = "Soft-boiled chicken eggs (2ct)",
                  Price = 14000,
                  VendorID = "5",
                  FoodCategoryID = "19"
              },
              new Food
              {
                  FoodID = "13",
                  VietnameseName = "Tháp 3 tầng combo",
                  EnglishName = "3 story tower combo",
                  Price = 29000,
                  VendorID = "5",
                  FoodCategoryID = "29"
              },
              new Food
              {
                  FoodID = "14",
                  VietnameseName = "Bún bò thập cẩm",
                  EnglishName = "Mixed beef vermicelli soup",
                  Price = 35000,
                  VendorID = "6",
                  FoodCategoryID = "4"
              },
              new Food
              {
                  FoodID = "15",
                  VietnameseName = "Trà sữa trân châu, bánh flan, phô mai viên",
                  EnglishName = "Milk tea with boba, flan cake and cheese ball",
                  Price = 45000,
                  VendorID = "7",
                  FoodCategoryID = "28"
              },
              new Food
              {
                  FoodID = "16",
                  VietnameseName = "Bún bò thập cẩm + giò",
                  EnglishName = "Mixed beef + pig's trotter vermicelli soup",
                  Price = 45000,
                  VendorID = "6",
                  FoodCategoryID = "4"
              },
              new Food
              {
                  FoodID = "17",
                  VietnameseName = "Phô mai viên (1 viên)",
                  EnglishName = "Cheese ball (1ct)",
                  Price = 2000,
                  VendorID = "7",
                  FoodCategoryID = "30"
              },
              new Food
              {
                  FoodID = "18",
                  VietnameseName = "Xôi 9 màu",
                  EnglishName = "9-color sweet sticky rice",
                  Price = 20000,
                  VendorID = "8",
                  FoodCategoryID = "12"
              },
              new Food
              {
                  FoodID = "19",
                  VietnameseName = "Trà sữa không topping",
                  EnglishName = "Milk tea without toppings",
                  Price = 17000,
                  VendorID = "9",
                  FoodCategoryID = "28"
              },
              new Food
              {
                  FoodID = "20",
                  VietnameseName = "Combos",
                  EnglishName = "Combos",
                  Price = 27000,
                  VendorID = "9",
                  FoodCategoryID = "28"
              },
              new Food
              {
                  FoodID = "21",
                  VietnameseName = "Trà sữa trái cây",
                  EnglishName = "Fruit milk tea",
                  Price = 15000,
                  VendorID = "9",
                  FoodCategoryID = "28"
              },
              new Food
              {
                  FoodID = "22",
                  VietnameseName = "Bánh tráng trộn trứng cút",
                  EnglishName = "Rice paper mix with quail eggs",
                  Price = 15000,
                  VendorID = "10",
                  FoodCategoryID = "19"
              },
              new Food
              {
                  FoodID = "23",
                  VietnameseName = "Sương sáo thập cẩm (1 lit.)",
                  EnglishName = "Grass jelly mix (1 lit.)",
                  Price = 15000,
                  VendorID = "11",
                  FoodCategoryID = "30"
              },
              new Food
              {
                  FoodID = "24",
                  VietnameseName = "Chè thập cẩm",
                  EnglishName = "Sweet gruel mixed combo",
                  Price = 10000,
                  VendorID = "11",
                  FoodCategoryID = "23"
              },
              new Food
              {
                  FoodID = "25",
                  VietnameseName = "Cốc tai trái cây",
                  EnglishName = "Fruit cocktails",
                  Price = 15000,
                  VendorID = "11",
                  FoodCategoryID = "30"
              },
              new Food
              {
                  FoodID = "26",
                  VietnameseName = "Chè đậu xanh",
                  EnglishName = "Sweet green bean gruel",
                  Price = 15000,
                  VendorID = "11",
                  FoodCategoryID = "23"
              },
              new Food
              {
                  FoodID = "27",
                  VietnameseName = "Bánh mì thịt nướng",
                  EnglishName = "Banh mi with grilled pork",
                  Price = 22000,
                  VendorID = "12",
                  FoodCategoryID = "13"
              },
              new Food
              {
                  FoodID = "28",
                  VietnameseName = "Bánh mì thịt nướng ốp la",
                  EnglishName = "Banh mi with grilled pork and omelette",
                  Price = 27000,
                  VendorID = "12",
                  FoodCategoryID = "13"
              },
              new Food
              {
                  FoodID = "29",
                  VietnameseName = "Bánh mì thịt nướng phô mai",
                  EnglishName = "Banh mi with grilled prok and cheese",
                  Price = 27000,
                  VendorID = "12",
                  FoodCategoryID = "13"
              },
              new Food
              {
                  FoodID = "30",
                  VietnameseName = "Hủ tiếu gõ chả, thịt, bò viên",
                  EnglishName = "Hu tieu go with fishcake, meat, and beef ball",
                  Price = 20000,
                  VendorID = "13",
                  FoodCategoryID = "2"
              },
              new Food
              {
                  FoodID = "31",
                  VietnameseName = "Bò bía (10 cuốn)",
                  EnglishName = "Popiah (10 rolls)",
                  Price = 30000,
                  VendorID = "14",
                  FoodCategoryID = "16"
              },
              new Food
              {
                  FoodID = "32",
                  VietnameseName = "Trà sữa (oolong, chocolate, matcha, oreo)",
                  EnglishName = "Milk tea (oolong, chocolate, matcha, oreo)",
                  Price = 20000,
                  VendorID = "15",
                  FoodCategoryID = "28"
              },
              new Food
              {
                  FoodID = "33",
                  VietnameseName = "Trà trái cây (xoài, đào, táo, vải, dâu, kiwi)",
                  EnglishName = "Fruit tea (mango, peach, apple, lychee, strawberry, kiwi)",
                  Price = 20000,
                  VendorID = "15",
                  FoodCategoryID = "28"
              },
              new Food
              {
                  FoodID = "35",
                  VietnameseName = "Trà sữa kem trứng",
                  EnglishName = "Egg cream milk tea",
                  Price = 25000,
                  VendorID = "15",
                  FoodCategoryID = "28"
              },
              new Food
              {
                  FoodID = "36",
                  VietnameseName = "Xiên que cá/bò/tôm:",
                  EnglishName = "Skewer (fish/beef/shrimp balls)",
                  Price = 6000,
                  VendorID = "15",
                  FoodCategoryID = "21"
              },
              new Food
              {
                  FoodID = "37",
                  VietnameseName = "Hoành thánh chiên (1ct)",
                  EnglishName = "Fried wontons (1ct)",
                  Price = 10000,
                  VendorID = "15",
                  FoodCategoryID = "30"
              },
              new Food
              {
                  FoodID = "38",
                  VietnameseName = "Khoai tây lắc phô mai",
                  EnglishName = "Cheese-soaked potato",
                  Price = 20000,
                  VendorID = "15",
                  FoodCategoryID = "30"
              },
              new Food
              {
                  FoodID = "39",
                  VietnameseName = "Bánh gạo lắc phô mai",
                  EnglishName = "Cheese-soaked rice cake",
                  Price = 20000,
                  VendorID = "15",
                  FoodCategoryID = "30"
              }
            );


        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder
            .UseNpgsql("Server=PostgreSQL;Host=localhost;Port=5432;Username=postgres;Password=street-foody;Database=street-foody;")
            .UseSnakeCaseNamingConvention();

    }
}