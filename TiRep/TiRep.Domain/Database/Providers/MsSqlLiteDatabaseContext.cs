using Microsoft.EntityFrameworkCore;
using TiRep.Domain.Database.Model;

namespace TiRep.Domain.Database.Providers
{
    public class MsSqlLiteDatabaseContext : DbContext
    {
        public DbSet<TimeReportDbModel> TimeReports { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite(@"Data Source=D:\GittHub\tirep\TiRep\TiRep.Domain\timereporting.db");
    }
}