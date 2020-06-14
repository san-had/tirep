using Microsoft.EntityFrameworkCore;

namespace EFGetStarted
{
    public class TimeReportContext : DbContext
    {
        public DbSet<TimeReport> TimeReports { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite(@"Data Source=D:\GittHub\tirep\TiRep\EFGetStarted\timereporting.db");
    }

    public class TimeReport
    {
        public int Id { get; set; }

        public string TimeReportText { get; set; }
    }
}