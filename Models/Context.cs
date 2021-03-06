using Microsoft.EntityFrameworkCore;  

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
        modelBuilder.Entity<StreetVendor>().Ignore(v => v.AverageRating);
        
        modelBuilder.Entity<StreetVendor>().HasData(
            new StreetVendor{VendorID = "1", StandVietnameseName = "Hủ tiếu Trần Bình Trọng", StandEnglishName = "Tran Binh Trong rice noodles", PriceRange = new int[]{15000,30000}, PhotoUrl = "https://static.riviu.co/640/image/2020/09/04/bef16221de75b45fea2dd579b5c9a29a_output.jpeg"},
            new StreetVendor{VendorID = "2", StandVietnameseName = "Bánh mì Dì Loan", StandEnglishName = "Aunty Loan's banh mi", PriceRange = new int[]{15000,20000}},
            new StreetVendor{VendorID = "3", StandVietnameseName = "Miến xào", StandEnglishName = "Miến xào", PriceRange = new int[]{10000,15000}},
            new StreetVendor{VendorID = "4", StandVietnameseName = "Xôi", StandEnglishName = "Sticky rice", PriceRange = new int[]{10000,15000}},
            new StreetVendor{VendorID = "5", StandVietnameseName = "Ăn vặt, trà sữa đường Vĩnh Viễn", StandEnglishName = "Vinh Vien St. snacks and boba tea", PriceRange = new int[]{14000,29000}, PhotoUrl = "https://scontent.ffcm1-2.fna.fbcdn.net/v/t1.0-9/156646575_817247045527459_8464517707157016028_n.jpg?_nc_cat=1&ccb=3&_nc_sid=b9115d&_nc_ohc=7qGQxbPz5GIAX94w5F1&_nc_ht=scontent.ffcm1-2.fna&oh=66f3c0a1330121b1100836f404c5ced8&oe=60685917"},
            new StreetVendor{VendorID = "6", StandVietnameseName = "Bún bò Bàu Sen", StandEnglishName = "Bau Sen market beef vermicelli soup", PriceRange = new int[]{35000,45000}, PhotoUrl = "https://scontent.ffcm1-2.fna.fbcdn.net/v/t1.0-9/84698123_1286864361515233_6961019376854106112_n.jpg?_nc_cat=108&ccb=3&_nc_sid=730e14&_nc_ohc=E1KHA4sGlc4AX_ZY4Mn&_nc_ht=scontent.ffcm1-2.fna&oh=8a56d06173f2342f91f7da037f89fff0&oe=60666BCB"},
            new StreetVendor{VendorID = "7", StandVietnameseName = "Trà sữa Anva", StandEnglishName = "Anva boba tea", PhotoUrl = "https://scontent.ffcm1-2.fna.fbcdn.net/v/t1.0-9/155165695_240195354407050_2744091707808776661_n.jpg?_nc_cat=101&ccb=3&_nc_sid=8bfeb9&_nc_ohc=05vpqk1kzbAAX9TFzD4&_nc_ht=scontent.ffcm1-2.fna&oh=6b0b19a21677cc60dc3c605d0746e109&oe=606906E4"},
            new StreetVendor{VendorID = "8", StandVietnameseName = "Xôi ngọt chị Ú", StandEnglishName = "Chubby sis's sweet sticky rice", PriceRange = new int[]{20000,25000}, PhotoUrl = "https://scontent.ffcm1-2.fna.fbcdn.net/v/t1.0-9/155122691_1246898299037777_4391716006726234458_n.jpg?_nc_cat=107&ccb=3&_nc_sid=b9115d&_nc_ohc=Oh-3nRYX_ywAX_XtP7F&_nc_ht=scontent.ffcm1-2.fna&oh=6d0ae3ea925ae24e6cc4fefe7eb8f5ec&oe=606915A1"},
            new StreetVendor{VendorID = "9", StandVietnameseName = "Tiger Tea", StandEnglishName = "Tiger Tea", PriceRange = new int[]{15000,40000}, PhotoUrl = "https://scontent.ffcm1-1.fna.fbcdn.net/v/t1.0-9/155512636_546860506277469_3968119529767571609_o.jpg?_nc_cat=109&ccb=3&_nc_sid=b9115d&_nc_ohc=a11O8kknWEQAX-WDDGL&_nc_ht=scontent.ffcm1-1.fna&oh=2bb5aef40ca9ab14683c771ff074e599&oe=6066F325"},
            new StreetVendor{VendorID = "10", StandVietnameseName = "Bánh tráng Bà Ngoại", StandEnglishName = "Grandma's rice paper mix", PriceRange = new int[]{15000,15000}, PhotoUrl = "https://static.riviu.co/960/image/2021/01/23/507d435341a6bf9a8b78f73b2498cff8_output.jpeg"},
            new StreetVendor{VendorID = "11", StandVietnameseName = "Chè cô Thủy", StandEnglishName = "Aunty Thuy's sweet gruel", PriceRange = new int[]{10000,15000}, PhotoUrl = "https://cdn01.diadiemanuong.com/ddau/999x/undefined-che-co-thuy-cao-dat-0-56b16e9637305080834967437.jpg"},
            new StreetVendor{VendorID = "12", StandVietnameseName = "Bánh mì Bà Nội", StandEnglishName = "Grandma's banh mi", PriceRange = new int[]{20000,25000}, PhotoUrl = "https://static.riviu.co/960/image/2020/06/15/f38acd6e2f5fa2c9e3529702ddc1f588_output.jpeg"},
            new StreetVendor{VendorID = "13", StandVietnameseName = "Hủ tiếu gõ 20k", StandEnglishName = "Hu tieu go 20k", PriceRange = new int[]{15000,20000}, PhotoUrl = "https://static.riviu.co/960/image/2020/11/23/60cc5128a4dae43cef57378f30e688c0_output.jpeg"},
            new StreetVendor{VendorID = "14", StandVietnameseName = "Bò bía 2 ông chú", StandEnglishName = "2 uncles' popiah", PriceRange = new int[]{30000,30000}, PhotoUrl = "https://static.riviu.co/960/image/2020/12/28/e02c4fae62a8993c43996561df2865a4_output.jpeg"},
            new StreetVendor{VendorID = "15", StandVietnameseName = "Green Box (Gibi)", StandEnglishName = "Green Box (Gibi)", PriceRange = new int[]{5000,40000}, PhotoUrl = "https://static.riviu.co/960/image/2020/12/04/67fabbc325dd84ba17fdc0e6e63978e9_output.jpeg"}
        );
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    => optionsBuilder
        .UseNpgsql("Server=PostgreSQL;Host=localhost;Port=5432;Username=postgres;Password=street-foody;Database=street-foody;")
        .UseSnakeCaseNamingConvention();

   } 
}