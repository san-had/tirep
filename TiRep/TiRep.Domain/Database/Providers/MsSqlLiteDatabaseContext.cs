using Microsoft.EntityFrameworkCore;
using TiRep.Domain.Database.Model;

namespace TiRep.Domain.Database.Providers
{
    public class MsSqlLiteDatabaseContext : DbContext
    {
        public DbSet<TimeReport> TimeReports { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=timereporting.db");
    }
}