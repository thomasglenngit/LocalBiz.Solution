  
using Microsoft.EntityFrameworkCore;

namespace LocalBiz.Models
{
    public class LocalBizContext : DbContext
    {
        public LocalBizContext(DbContextOptions<LocalBizContext> options)
            : base(options)
        {
        }

        public DbSet<Biz> Bizs { get; set; }
        public DbSet<Resto> Restos { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Biz>()
                .HasData(
                    
                    new Biz { BizId = 2, Name = "Great Lakes Bank", Address = "405 - 3 Wacker Drive, Chicago, IL", Type = "Financial - Bank", RUrl = "info@glbanking.com"},
                    new Biz { BizId = 4, Name = "Tip Top Tailor", Address = "#4334 Williams Street, Chicago, IL", Type = "Dry Cleaning/Tailor", RUrl = "charlie@tiptop.com"},
                    new Biz { BizId = 5, Name = "Euro Cars", Address = "#253 Jackson Avenue, Chicago, IL", Type = "Auto Mechanic", Url = "info@eurocars.com"},
                    new Biz { BizId = 7, Name = "Trip and Slide", Address = "#478 Cander Avenue, Chicago, IL", Type = "Recreational - Roller Rink", Url = "info@tripandslide.com"},
                    new Biz { BizId = 9, Name = "Tax Grind", Address = "#4446 - 305 Jackson Avenue, Chicago, IL", Type = "Financial - Tax Preparation", Url = "info@taxgrind.com"}

                );
            
            builder.Entity<Resto>()
                .HasData(
                    new Biz { RestoId = 1, RName = "Wok With Me", RAddress = "#1 Happy Street, Chicago, IL", RType = "Restaurant - Chinese", RUrl = "info@wokwithme.com"},
                    new Biz { RestoId = 3, RName = "Panera", RAddress = "#455 Michigan Avenue, Chicago, IL", RType = "Restaurant - American", RUrl = "info@panera.com"},
                    new Biz { RestoId = 6, RName = "Pretzel Choke", RAddress = "#3446 - 55 N. Wacker Drive, Chicago, IL", RType = "Restaurant - German", RUrl = "info@pretzelchoke.com"},
                    new Biz { RestoId = 8, RName = "Green Tongue", RAddress = "#3 Anderson Road, Chicago, IL", RType = "Restaurant - Health Food", RUrl = "info@greentongue.com"}
                );
        }
    }
}