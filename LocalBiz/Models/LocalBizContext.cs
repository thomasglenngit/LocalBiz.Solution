  
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
    }
}