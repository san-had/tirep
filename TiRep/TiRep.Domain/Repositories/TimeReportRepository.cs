using TiRep.Domain.Database.Model;
using TiRep.Domain.Database.Providers;

namespace TiRep.Domain.Repositories
{
    public class TimeReportRepository
    {
        private readonly MsSqlLiteDatabaseContext dbContext;

        public TimeReportRepository(MsSqlLiteDatabaseContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public int Create(TimeReport timeReport)
        {
            dbContext.Add(timeReport);
            dbContext.SaveChanges();
            return timeReport.Id;
        }
    }
}