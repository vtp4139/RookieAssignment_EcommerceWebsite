using EcommerceWebsite.Backend.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace EcommerceWebsite.Backend.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<ImageFile> ImageFiles { get; set; }
        public DbSet<Rating> Ratings { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<OrderDetail>()
            .HasKey(pc => new { pc.ProductID, pc.OrderID });

            modelBuilder.Entity<OrderDetail>()
                .HasOne(pc => pc.Product)
                .WithMany(p => p.OrderDetails)
                .HasForeignKey(pc => pc.ProductID);

            modelBuilder.Entity<OrderDetail>()
                .HasOne(pc => pc.Order)
                .WithMany(c => c.OrderDetails)
                .HasForeignKey(pc => pc.OrderID);

            modelBuilder.Entity<User>()
                .ToTable("AspNetUsers");

            //Seeding data
            modelBuilder.Entity<Categories>().HasData(
                 new Categories 
                 { 
                     CategoryID = 1, 
                     CategoryName = "Chuột", 
                     Description = "Cung cấp các mặt hàng chuột chất lượng nhất đến từ các hãng uy tín hiện nay. Đảm bảo chính hãng và bảo hành 6 tháng."
                 },
                 new Categories 
                 { 
                     CategoryID = 2, 
                     CategoryName = "Bàn phím", 
                     Description = "Cung cấp các mặt hàng bàn phím chất lượng nhất đến từ các hãng uy tín hiện nay. Đảm bảo chính hãng và bảo hành 6 tháng."
                 },
                 new Categories 
                 { 
                     CategoryID = 3, 
                     CategoryName = "Màn hình", 
                     Description = "Cung cấp các mặt hàng màn hình chất lượng nhất đến từ các hãng uy tín hiện nay. Đảm bảo chính hãng và bảo hành 6 tháng."
                 });
            
            modelBuilder.Entity<Product>().HasData(
                  new Product 
                  {
                      ProductID = 1, 
                      ProductName = "Chuột Logitech G102 Lightsync RGB Black", 
                      Description = "Khi lưu các cấu hình vào bộ nhớ trong bằng phần mềm HUB G của Chuột Logitech, bạn có thể sử dụng nó trên các máy tính khác mà không cần cài đặt phần mềm hoặc các cấu hình lại một lần nữa. Cắm vào là sử dụng theo ý thích của bạn.", 
                      Price = 400, 
                      CreatedDate = DateTime.Now, 
                      UpdatedDate = DateTime.Now, 
                      CategoryID = 1 
                  },
                  new Product
                  {
                      ProductID = 2,
                      ProductName = "Chuột Logitech G502 Hero",
                      Description = "Ngoài hiệu suất cốt lõi và các tính năng cá nhân, nhiều chi tiết được thiết kế và chế tạo với sự tận tâm. Logitech G502 Hero là một trong những dòng chuột gaming giá rẻ so với các sản phẩm ở cùng phân khúc với dây bện với nút buộc dây có khóa nhám, phần cầm nắm bên có viền cao su, cửa từ vào khoang để khối nặng và nhiều hơn nữa.",
                      Price = 400,
                      CreatedDate = DateTime.Now,
                      UpdatedDate = DateTime.Now,
                      CategoryID = 1
                  },
                  new Product
                  {
                      ProductID = 3,
                      ProductName = "Chuột Logitech G302 Daedalus Prime",
                      Description = "Logitech G302 Daedalus Prime là một trong những sản phẩm tiêu biểu trong phong cách thiết kế đơn giản, tập trung vào tốc độ, sự chính xác và tính hiệu quả trong mỗi cú nhấn chuột của game thủ, đặc biệt với thể loại game MOBA.",
                      Price = 590,
                      CreatedDate = DateTime.Now,
                      UpdatedDate = DateTime.Now,
                      CategoryID = 1
                  },
                  new Product
                  {
                      ProductID = 4,
                      ProductName = "Chuột Logitech G402 Hyperion",
                      Description = "Chuột Logitech G402 sở hữu tốc độ quét lên tới 500 IPS, sử dụng công nghệ cảm biến mới nhất của Logitech là Fusion Engine cho độ chính xác cực cao khi sử dụng.",
                      Price = 640,
                      CreatedDate = DateTime.Now,
                      UpdatedDate = DateTime.Now,
                      CategoryID = 1
                  },
                  new Product
                  {
                      ProductID = 5,
                      ProductName = "Razer PBT Keycap Upgrade Set",
                      Description = "Đã đến lúc trở nên quyết đoán hơn trong từng cú bấm phím mang tới khả năng chiến thắng trong mọi trận đấu. Với bộ nâng cấp Keycap Razer PBT. Được thiết kế để sử dụng trong những trò chơi khốc liệt nhất, những chiếc keycaps PBT doubleshot này được thiết kế để giành chiến thắng trong mọi trận chiến.",
                      Price = 890,
                      CreatedDate = DateTime.Now,
                      UpdatedDate = DateTime.Now,
                      CategoryID = 2
                  },
                  new Product
                  {
                      ProductID = 6,
                      ProductName = "Razer Level Up Bundle (Cynosa Lite + Viper Mini + Gigantus V2 Medium)",
                      Description = "Sản phẩm đầu tiên trong combo sẽ là chiếc bàn phím giả cơ Razer Cynosa Lite. Sở hữu thiết kế đơn giản, tông màu đen huyền bí và khả năng tùy biến LED RGB Razer Chroma cho Cynosa Lite vẻ đẹp bắt mắt không thua kém những chiếc bàn phím cơ Razer khác. Các phím được lập trình sẵn những chức năng hữu ích macro cho bàn phím Cynosa Lite thuận tiện hơn trong việc sử dụng.",
                      Price = 199,
                      CreatedDate = DateTime.Now,
                      UpdatedDate = DateTime.Now,
                      CategoryID = 2
                  },
                   new Product
                   {
                       ProductID = 7,
                       ProductName = "Bàn phím Razer Blackwidow Lite",
                       Description = "Razer™ Mechanical Switches with 50g actuation force",
                       Price = 199,
                       CreatedDate = DateTime.Now,
                       UpdatedDate = DateTime.Now,
                       CategoryID = 2
                   },
                   new Product
                   {
                       ProductID = 8,
                       ProductName = "Bàn phím Razer Blackwidow Lite Mercury",
                       Description = "Razer™ Mechanical Switches with 50g actuation force",
                       Price = 299,
                       CreatedDate = DateTime.Now,
                       UpdatedDate = DateTime.Now,
                       CategoryID = 2
                   },
                   new Product
                   {
                       ProductID = 9,
                       ProductName = "Màn hình LG 20MK400H-B 19.5 - HD TN",
                       Description = "Giảm ánh sáng xanh nhằm giúp làm giảm sự mệt mỏi của mắt, Chế độ đọc sách mang đến điều kiện đọc sách tối ưu. Với điều khiển tay cầm dễ dàng, bạn có đọc thoải mái hơn màn hình của bạn.",
                       Price = 1299,
                       CreatedDate = DateTime.Now,
                       UpdatedDate = DateTime.Now,
                       CategoryID = 3
                   },
                   new Product
                   {
                       ProductID = 10,
                       ProductName = "Màn hình LG 22MN430M-B 22 IPS 75Hz FreeSync",
                       Description = "LG 22MN430M-B là một mẫu màn hình hướng đến đối tượng là dân văn phòng, đáp ứng được những nhu cầu cơ bản, cho bạn một khung nhìn để làm việc, cũng như xem phim, chơi game với một mức giá bình dân nhất có thể. ",
                       Price = 2800,
                       CreatedDate = DateTime.Now,
                       UpdatedDate = DateTime.Now,
                       CategoryID = 3
                   },
                   new Product
                   {
                       ProductID = 11,
                       ProductName = "Màn hình LG 24MK430H-B 24 IPS 75Hz OC FreeSyn",
                       Description = "LG 24MK430H-B là một mẫu màn hình hướng đến đối tượng là dân văn phòng, đáp ứng được những nhu cầu cơ bản, cho bạn một khung nhìn để làm việc, cũng như xem phim, chơi game mới một mức giá bình dân nhất có thể.",
                       Price = 3000,
                       CreatedDate = DateTime.Now,
                       UpdatedDate = DateTime.Now,
                       CategoryID = 3
                   },
                   new Product
                   {
                       ProductID = 12,
                       ProductName = "Màn hình LG 24MP59G-P 24 IPS 75Hz Freesync chuyên game",
                       Description = "Đa số game thủ bình dân đều muốn có cho mình một chiếc màn hình vừa phải có mức giá phải chăng dễ tiếp cận, vừa có những thông số kỹ thuật cân bằng để phục vụ không chỉ việc chơi game mà còn có thể xem phim và làm nhiều chuyện khác nữa. Hiểu được điều đó, LG đã cho ra mắt LG 24MP59G-P - một sự lựa chọn sáng giá trong phân khúc bình dân.",
                       Price = 3200,
                       CreatedDate = DateTime.Now,
                       UpdatedDate = DateTime.Now,
                       CategoryID = 3
                   });

            modelBuilder.Entity<ImageFile>().HasData(
                new ImageFile
                {
                    ImageId = 1,
                    ImageLocation = "/images/g102-g20315.png",
                    UploadedTime = DateTime.Now,
                    ProductID = 1

                },
                new ImageFile
                {
                    ImageId = 2,
                    ImageLocation = "/images/logitech-g502.jpg",
                    UploadedTime = DateTime.Now,
                    ProductID = 2
                },
                new ImageFile
                {
                     ImageId = 3,
                     ImageLocation = "/images/logitech-g302_1.jpg",
                     UploadedTime = DateTime.Now,
                     ProductID = 3
                },
                new ImageFile
                {
                    ImageId = 4,
                    ImageLocation = "/images/logitech-g402.jpg",
                    UploadedTime = DateTime.Now,
                    ProductID = 4
                },
                new ImageFile
                {
                    ImageId = 5,
                    ImageLocation = "/images/Razer-PBT-Keycap-Upgrade-Set-Classic-Black.jpg",
                    UploadedTime = DateTime.Now,
                    ProductID = 5
                },
                new ImageFile
                {
                    ImageId = 6,
                    ImageLocation = "/images/Razer-Level-Up-Bundle_cynosa_lite_viper_mini_gigantus_v2.jpg",
                    UploadedTime = DateTime.Now,
                    ProductID = 6
                },
                new ImageFile
                {
                    ImageId = 7,
                    ImageLocation = "/images/Razer-Blackwidow-Lite-Mercury.jpg",
                    UploadedTime = DateTime.Now,
                    ProductID = 7
                },
                new ImageFile
                {
                    ImageId = 8,
                    ImageLocation = "/images/Razer_Blackwidow_Lite_Mercury_White.jpg",
                    UploadedTime = DateTime.Now,
                    ProductID = 8
                }, new ImageFile
                {
                    ImageId = 9,
                    ImageLocation = "/images/lg_20mk400h_b_19_5inch_led_1_2.png",
                    UploadedTime = DateTime.Now,
                    ProductID = 9
                },
                new ImageFile
                {
                    ImageId = 10,
                    ImageLocation = "/images/LG-22MN430-new.jpg",
                    UploadedTime = DateTime.Now,
                    ProductID = 10
                },
                new ImageFile
                {
                    ImageId = 11,
                    ImageLocation = "/images/LG-24MK430H-B 24.jpg",
                    UploadedTime = DateTime.Now,
                    ProductID = 11
                },
                new ImageFile
                {
                    ImageId = 12,
                    ImageLocation = "/images/LG-24MP59G-P 24-IPS.jpg",
                    UploadedTime = DateTime.Now,
                    ProductID = 12
                });
        }
    }
}
