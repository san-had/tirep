using System;
using TiRep.Extensibility;
using TiRep.Extensibility.Dto;

namespace TiRep.Service
{
    public class TimeReportService : ITimeReportService
    {
        private readonly ITimeReportRepository timeReportRepository;

        public TimeReportService()
        {
        }

        public void CreateTimeReport(TimeReportDto timeReportDto)
        {
            throw new NotImplementedException();
        }
    }
}