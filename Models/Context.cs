using Microsoft.EntityFrameworkCore;  
using System.Collections.Generic;

namespace street_foody.Models {     
public class Context : DbContext     
  {         
    public Context(DbContextOptions<Context> options): base(options)         
{ 
          
}

    public DbSet<StreetVendor> StreetVendor { get; set;}
    public DbSet<Food> Food { get; set; }     
    public DbSet<FoodCategory> FoodCategory { get; set; }     
    public DbSet<VendorHours> VendorHours { get; set; }     
  
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // AverageRating is used as part of the ViewModel, not the Entity model.
        // modelBuilder.Entity<StreetVendor>().Ignore(v => v.AverageRating); 
        // Pull from github, drop and then update the database to see newly seeded data.
        // modelBuilder.Entity<StreetVendor>().HasData(
        //     new StreetVendor{VendorID = "1", StandVietnameseName = "Hủ tiếu Trần Bình Trọng", StandEnglishName = "Tran Binh Trong rice noodles", RatingList = new int[]{4,4,4}, PriceRange = new int[]{15000,30000}, PhotoUrl = "https://static.riviu.co/640/image/2020/09/04/bef16221de75b45fea2dd579b5c9a29a_output.jpeg"},
        //     new StreetVendor{VendorID = "2", StandVietnameseName = "Bánh mì Dì Loan", StandEnglishName = "Aunty Loan's banh mi", RatingList = new int[]{5}, PriceRange = new int[]{15000,20000}},
        //     new StreetVendor{VendorID = "3", StandVietnameseName = "Miến xào", StandEnglishName = "Miến xào",  RatingList = new int[]{5}, PriceRange = new int[]{10000,15000}},
        //     new StreetVendor{VendorID = "4", StandVietnameseName = "Xôi", StandEnglishName = "Sticky rice", RatingList = new int[]{3}, PriceRange = new int[]{10000,15000}},
        //     new StreetVendor{VendorID = "5", StandVietnameseName = "Ăn vặt, trà sữa đường Vĩnh Viễn", StandEnglishName = "Vinh Vien St. snacks and boba tea", RatingList = new int[]{}, PriceRange = new int[]{14000,29000}, PhotoUrl = "https://scontent.ffcm1-2.fna.fbcdn.net/v/t1.0-9/156646575_817247045527459_8464517707157016028_n.jpg?_nc_cat=1&ccb=3&_nc_sid=b9115d&_nc_ohc=7qGQxbPz5GIAX94w5F1&_nc_ht=scontent.ffcm1-2.fna&oh=66f3c0a1330121b1100836f404c5ced8&oe=60685917"},
        //     new StreetVendor{VendorID = "6", StandVietnameseName = "Bún bò Bàu Sen", StandEnglishName = "Bau Sen market beef vermicelli soup", RatingList = new int[]{5}, PriceRange = new int[]{35000,45000}, PhotoUrl = "https://scontent.ffcm1-2.fna.fbcdn.net/v/t1.0-9/84698123_1286864361515233_6961019376854106112_n.jpg?_nc_cat=108&ccb=3&_nc_sid=730e14&_nc_ohc=E1KHA4sGlc4AX_ZY4Mn&_nc_ht=scontent.ffcm1-2.fna&oh=8a56d06173f2342f91f7da037f89fff0&oe=60666BCB"},
        //     new StreetVendor{VendorID = "7", StandVietnameseName = "Trà sữa Anva", StandEnglishName = "Anva boba tea", RatingList = new int[]{}, PriceRange = new int[]{}, PhotoUrl = "https://scontent.ffcm1-2.fna.fbcdn.net/v/t1.0-9/155165695_240195354407050_2744091707808776661_n.jpg?_nc_cat=101&ccb=3&_nc_sid=8bfeb9&_nc_ohc=05vpqk1kzbAAX9TFzD4&_nc_ht=scontent.ffcm1-2.fna&oh=6b0b19a21677cc60dc3c605d0746e109&oe=606906E4"},
        //     new StreetVendor{VendorID = "8", StandVietnameseName = "Xôi ngọt chị Ú", StandEnglishName = "Chubby sis's sweet sticky rice", PriceRange = new int[]{20000,25000}, PhotoUrl = "https://scontent.ffcm1-2.fna.fbcdn.net/v/t1.0-9/155122691_1246898299037777_4391716006726234458_n.jpg?_nc_cat=107&ccb=3&_nc_sid=b9115d&_nc_ohc=Oh-3nRYX_ywAX_XtP7F&_nc_ht=scontent.ffcm1-2.fna&oh=6d0ae3ea925ae24e6cc4fefe7eb8f5ec&oe=606915A1"},
        //     new StreetVendor{VendorID = "9", StandVietnameseName = "Tiger Tea", StandEnglishName = "Tiger Tea", RatingList = new int[]{5}, PriceRange = new int[]{15000,40000}, PhotoUrl = "https://scontent.ffcm1-1.fna.fbcdn.net/v/t1.0-9/155512636_546860506277469_3968119529767571609_o.jpg?_nc_cat=109&ccb=3&_nc_sid=b9115d&_nc_ohc=a11O8kknWEQAX-WDDGL&_nc_ht=scontent.ffcm1-1.fna&oh=2bb5aef40ca9ab14683c771ff074e599&oe=6066F325"},
        //     new StreetVendor{VendorID = "10", StandVietnameseName = "Bánh tráng Bà Ngoại", StandEnglishName = "Grandma's rice paper mix", RatingList = new int[]{5,5,5,4}, PriceRange = new int[]{15000,15000}, PhotoUrl = "https://static.riviu.co/960/image/2021/01/23/507d435341a6bf9a8b78f73b2498cff8_output.jpeg"},
        //     new StreetVendor{VendorID = "11", StandVietnameseName = "Chè cô Thủy", StandEnglishName = "Aunty Thuy's sweet gruel", RatingList = new int[]{5,5,5,5}, PriceRange = new int[]{10000,15000}, PhotoUrl = "https://cdn01.diadiemanuong.com/ddau/999x/undefined-che-co-thuy-cao-dat-0-56b16e9637305080834967437.jpg"},
        //     new StreetVendor{VendorID = "12", StandVietnameseName = "Bánh mì Bà Nội", StandEnglishName = "Grandma's banh mi", RatingList = new int[]{4}, PriceRange = new int[]{20000,25000}, PhotoUrl = "https://static.riviu.co/960/image/2020/06/15/f38acd6e2f5fa2c9e3529702ddc1f588_output.jpeg"},
        //     new StreetVendor{VendorID = "13", StandVietnameseName = "Hủ tiếu gõ 20k", StandEnglishName = "Hu tieu go 20k", RatingList = new int[]{5}, PriceRange = new int[]{15000,20000}, PhotoUrl = "https://static.riviu.co/960/image/2020/11/23/60cc5128a4dae43cef57378f30e688c0_output.jpeg"},
        //     new StreetVendor{VendorID = "14", StandVietnameseName = "Bò bía 2 ông chú", StandEnglishName = "2 uncles' popiah", RatingList = new int[]{5}, PriceRange = new int[]{30000,30000}, PhotoUrl = "https://static.riviu.co/960/image/2020/12/28/e02c4fae62a8993c43996561df2865a4_output.jpeg"},
        //     new StreetVendor{VendorID = "15", StandVietnameseName = "Green Box (Gibi)", StandEnglishName = "Green Box (Gibi)", RatingList = new int[]{3,4,4}, PriceRange = new int[]{5000,40000}, PhotoUrl = "https://static.riviu.co/960/image/2020/12/04/67fabbc325dd84ba17fdc0e6e63978e9_output.jpeg"}
        // );

        // modelBuilder.Entity<VendorHours>().HasData(
        //   new VendorHours{VendorID = "1", Location = "359 Tran Binh Trong, Ward 1, District 10, HCMC", VendorHoursInfo = "Sun - Sat", StartTime = "3pm", EndTime = "9pm"},
        //   new VendorHours{VendorID = "2", Location = "15 D5 St., Ward 25, Binh Thanh District, HCMC", VendorHoursInfo = "Mon - Sat", StartTime = "5am", EndTime = "11am"},
        //   new VendorHours{VendorID = "3", Location = "10-12 Dinh Tien Hoang St., Ben Nghe Ward, District 1, HCMC", VendorHoursInfo = "Mon - Fri", StartTime = "10am", EndTime = "12pm"},
        //   new VendorHours{VendorID = "4", Location = "217 Hong Bang, Ward 1, District 5, HCMC", VendorHoursInfo = "Mon - Fri", StartTime = "6am", EndTime = "8am"},
        //   new VendorHours{VendorID = "5", Location = "82 Vinh Vien, Ward 2, District 10, HCMC", VendorHoursInfo = "Sun - Sat", StartTime = "9am", EndTime = "10pm"},
        //   new VendorHours{VendorID = "6", Location = "138 Nguyen Trai, Ward 3, District 5", VendorHoursInfo = "Sun - Sat", StartTime = "5pm", EndTime = "12am"},
        //   new VendorHours{VendorID = "7", Location = "267 Pham Van Chi, Ward 3, District 6", VendorHoursInfo = "Sun - Sat", StartTime = "11am", EndTime = "9pm"},
        //   new VendorHours{VendorID = "8", Location = "8 Phan Van Han, Ward 19, Binh Thanh District", VendorHoursInfo = "Sun - Sat", StartTime = "3pm", EndTime = "N/A"},
        //   new VendorHours{VendorID = "9", Location = "27 Thanh Da, Ward 27, Binh Thanh District", VendorHoursInfo = "Sun - Sat", StartTime = "6pm", EndTime = "10pm"},
        //   new VendorHours{VendorID = "10", Location = "623/20 CMT8, P.15, Q.10", VendorHoursInfo = "Sun - Sat", StartTime = "5:30pm", EndTime = "10pm"},
        //   new VendorHours{VendorID = "11", Location = "897/29 Tran Hung Dao, Ward 01, District 5, HCMC", VendorHoursInfo = "Sun - Sat", StartTime = "11am", EndTime = "5pm"},
        //   new VendorHours{VendorID = "12", Location = "246/55A Hoa Hung, Ward 13, District 10", VendorHoursInfo = "Sun - Sat", StartTime = "6am", EndTime = "9pm"},
        //   new VendorHours{VendorID = "13", Location = "48 Kha Van Can St., Binh Chanh Ward, Thu Duc District", VendorHoursInfo = "Sun - Sat", StartTime = "6pm", EndTime = "10pm"},
        //   new VendorHours{VendorID = "14", Location = "Le Van Tam Park", VendorHoursInfo = "Sun - Sat", StartTime = "5pm", EndTime = "10pm"},
        //   new VendorHours{VendorID = "15", Location = "38 Phạm Ngọc Thạch, P.6, Q.3, HCM", VendorHoursInfo = "Sun - Sat", StartTime = "12pm", EndTime = "11pm"}
        // );

        modelBuilder.Entity<FoodCategory>().HasData(
          new FoodCategory{FoodCategoryID = "1", CategoryVietnameseName = "Phở", CategoryEnglishName = "Pho", Description = ""},
          new FoodCategory{FoodCategoryID = "2", CategoryVietnameseName = "Hủ tiếu", CategoryEnglishName = "Rice noodles, or simply hu tieu", Description = ""},
          new FoodCategory{FoodCategoryID = "3", CategoryVietnameseName = "Mì", CategoryEnglishName = "Egg noodles", Description = ""},
          new FoodCategory{FoodCategoryID = "4", CategoryVietnameseName = "Bún", CategoryEnglishName = "Vietnamese rice vermicelli", Description = ""},
          new FoodCategory{FoodCategoryID = "5", CategoryVietnameseName = "Bánh canh", CategoryEnglishName = "Tapioca noodles, banh canh", Description = ""},
          new FoodCategory{FoodCategoryID = "6", CategoryVietnameseName = "Miến", CategoryEnglishName = "Cellophane noodles/glass noodles", Description = ""},
          new FoodCategory{FoodCategoryID = "7", CategoryVietnameseName = "Nui", CategoryEnglishName = "Vietnamese macaroni", Description = ""},
          new FoodCategory{FoodCategoryID = "8", CategoryVietnameseName = "Bánh cuốn", CategoryEnglishName = "Steamed rice rolls, Rice noodle rolls", Description = ""},
          new FoodCategory{FoodCategoryID = "9", CategoryVietnameseName = "Cơm tấm", CategoryEnglishName = "Vietnamese broken rice", Description = ""},
          new FoodCategory{FoodCategoryID = "10", CategoryVietnameseName = "Cháo", CategoryEnglishName = "Congee", Description = ""},
          new FoodCategory{FoodCategoryID = "11", CategoryVietnameseName = "Súp", CategoryEnglishName = "Egg drop soup", Description = ""},
          new FoodCategory{FoodCategoryID = "12", CategoryVietnameseName = "Xôi", CategoryEnglishName = "Sticky rice", Description = ""},
          new FoodCategory{FoodCategoryID = "13", CategoryVietnameseName = "Bánh mì", CategoryEnglishName = "Vietnamese sandwich", Description = ""},
          new FoodCategory{FoodCategoryID = "14", CategoryVietnameseName = "Bánh bao", CategoryEnglishName = "Vietnamese steamed bun", Description = ""},
          new FoodCategory{FoodCategoryID = "15", CategoryVietnameseName = "Điểm sấm", CategoryEnglishName = "Dim sum", Description = ""},
          new FoodCategory{FoodCategoryID = "16", CategoryVietnameseName = "Cuốn", CategoryEnglishName = "Rolls", Description = ""},
          new FoodCategory{FoodCategoryID = "17", CategoryVietnameseName = "Pancakes", CategoryEnglishName = "Crispy pancakes", Description = ""},
          new FoodCategory{FoodCategoryID = "18", CategoryVietnameseName = "Bánh tráng", CategoryEnglishName = "Rice paper", Description = ""},
          new FoodCategory{FoodCategoryID = "19", CategoryVietnameseName = "Trứng", CategoryEnglishName = "Eggs", Description = ""},
          new FoodCategory{FoodCategoryID = "20", CategoryVietnameseName = "Bánh ngọt", CategoryEnglishName = "Sweet cakes", Description = ""},
          new FoodCategory{FoodCategoryID = "21", CategoryVietnameseName = "Xiên que", CategoryEnglishName = "Skewers", Description = ""},
          new FoodCategory{FoodCategoryID = "22", CategoryVietnameseName = "Trái cây", CategoryEnglishName = "Fruits", Description = ""},
          new FoodCategory{FoodCategoryID = "23", CategoryVietnameseName = "Chè", CategoryEnglishName = "Sweet gruel", Description = ""},
          new FoodCategory{FoodCategoryID = "24", CategoryVietnameseName = "Nước ép", CategoryEnglishName = "Juice", Description = ""},
          new FoodCategory{FoodCategoryID = "25", CategoryVietnameseName = "Nước đóng chai", CategoryEnglishName = "Bottled drinks", Description = ""},
          new FoodCategory{FoodCategoryID = "26", CategoryVietnameseName = "Trà", CategoryEnglishName = "Tea", Description = ""},
          new FoodCategory{FoodCategoryID = "27", CategoryVietnameseName = "Cà phê", CategoryEnglishName = "Vietnamese coffee", Description = ""},
          new FoodCategory{FoodCategoryID = "28", CategoryVietnameseName = "Trà sữa", CategoryEnglishName = "Boba tea", Description = ""},
          new FoodCategory{FoodCategoryID = "29", CategoryVietnameseName = "Tráng miệng", CategoryEnglishName = "Dessert", Description = ""}
        );

    }

     
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    => optionsBuilder
        .UseNpgsql("Server=PostgreSQL;Host=localhost;Port=5432;Username=postgres;Password=street-foody;Database=street-foody;")
        .UseSnakeCaseNamingConvention();

   } 
}