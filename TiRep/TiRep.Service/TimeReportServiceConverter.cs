using System;
using TiRep.Extensibility;
using TiRep.Extensibility.Dto;
using TiRep.Extensibility.Model;

namespace TiRep.Service
{
    public class TimeReportServiceConverter : ITimeReportServiceConverter
    {
        private readonly IDateTimeProvider dateTimeProvider;
        private readonly IRecordIdParser recordIdParser;

        public TimeReportServiceConverter(IDateTimeProvider dateTimeProvider, IRecordIdParser recordIdParser)
        {
            this.dateTimeProvider = dateTimeProvider;
            this.recordIdParser = recordIdParser;
        }

        public TimeReportServiceModel Convert(TimeReportDto source)
        {
            var timeReportServiceModel = new TimeReportServiceModel
            {
                RecordId = recordIdParser.ParseRecordId(DateTime.Parse(source.StartTime)),
                StartTime = DateTime.Parse(source.StartTime),
                EndTime = DateTime.Parse(source.EndTime),
                Deduction = TimeSpan.Parse(source.Deduction)
            };

            return timeReportServiceModel;
        }

        public TimeReportDto Convert(TimeReportServiceModel source)
        {
            throw new NotImplementedException();
        }
    }
}