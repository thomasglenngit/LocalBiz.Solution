using Microsoft.EntityFrameworkCore;

namespace LocalBiz.Models
{
    public class LocalBizContext : DbContext
    {
        public LocalBizContext(DbContextOptions<LocalBizContext> options)
            : base(options)
        {
        }

        public DbSet<Adress> Adresses { get; set; }
    }
}