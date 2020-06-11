using TiRep.Domain.Database.Model;
using TiRep.Extensibility.Model;

namespace TiRep.Domain.Converters
{
    public class TimeReportEntityConverter : ITimeReportEntityConverter
    {
        public TimeReportDbModel Convert(TimeReportServiceModel source)
        {
            return source != null
                ? new TimeReportDbModel
                {
                    Id = source.Id,
                    RecordId = source.RecordId,
                    StartTime = source.StartTime,
                    EndTime = source.EndTime,
                    Deduction = source.Deduction,
                    Balance = source.Balance,
                    FinalBalance = source.FinalBalance
                } : null;
        }

        public TimeReportServiceModel Convert(TimeReportDbModel source)
        {
            return new TimeReportServiceModel
            {
                Id = source.Id,
                RecordId = source.RecordId,
                StartTime = source.StartTime,
                EndTime = source.EndTime,
                Deduction = source.Deduction,
                Balance = source.Balance,
                FinalBalance = source.FinalBalance
            };
        }
    }
}