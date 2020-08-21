  
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
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Biz>()
                .HasData(
                    new Biz { BizId = 1, Name = "Wok With Me", Address = "#1 Happy Street, Chicago, IL", Type = "Restaurant - Chinese", Url = "info@wokwithme.com"},
                    new Biz { BizId = 2, Name = "Great Lakes Bank", Address = "405 - 3 Wacker Drive, Chicago, IL", Type = "Financial - Bank", Url = "info@glbanking.com"},
                    new Biz { BizId = 3, Name = "Panera", Address = "#455 Michigan Avenue, Chicago, IL", Type = "Restaurant - American", Url = "info@panera.com"},
                    new Biz { BizId = 4, Name = "Tip Top Tailor", Address = "#4334 Williams Street, Chicago, IL", Type = "Dry Cleaning/Tailor", Url = "charlie@tiptop.com"},
                    new Biz { BizId = 5, Name = "Euro Cars", Address = "#253 Jackson Avenue, Chicago, IL", Type = "Auto Mechanic", Url = "info@eurocars.com"},
                    new Biz { BizId = 6, Name = "Pretzel Choke", Address = "#3446 - 55 N. Wacker Drive, Chicago, IL", Type = "Restaurant - German", Url = "info@pretzelchoke.com"},
                    new Biz { BizId = 7, Name = "Trip and Slide", Address = "#478 Cander Avenue, Chicago, IL", Type = "Recreational - Roller Rink", Url = "info@tripandslide.com"},
                    new Biz { BizId = 8, Name = "Green Tongue", Address = "#3 Anderson Road, Chicago, IL", Type = "Restaurant - Health Food", Url = "info@greentongue.com"},
                    new Biz { BizId = 9, Name = "Tax Grind", Address = "#4446 - 305 Jackson Avenue, Chicago, IL", Type = "Financial - Tax Preparation", Url = "info@taxgrind.com"}

                );
        }
    }
}