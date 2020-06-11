using TiRep.Domain.Converters;
using TiRep.Domain.Database.Model;
using TiRep.Domain.Database.Providers;
using TiRep.Extensibility.Model;

namespace TiRep.Domain.Repositories
{
    public class TimeReportRepository
    {
        private readonly MsSqlLiteDatabaseContext dbContext;
        private readonly ITimeReportEntityConverter timeReportEntityConverter;

        public TimeReportRepository(MsSqlLiteDatabaseContext dbContext, ITimeReportEntityConverter timeReportEntityConverter)
        {
            this.dbContext = dbContext;
            this.timeReportEntityConverter = timeReportEntityConverter;
        }

        public int Create(TimeReportServiceModel timeReportModel)
        {
            TimeReportDbModel timeReport = timeReportEntityConverter.Convert(timeReportModel);
            dbContext.Add(timeReport);
            dbContext.SaveChanges();
            return timeReport.Id;
        }
    }
}