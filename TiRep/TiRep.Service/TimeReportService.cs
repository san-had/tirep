using TiRep.Extensibility;
using TiRep.Extensibility.Dto;

namespace TiRep.Service
{
    public class TimeReportService : ITimeReportService
    {
        private readonly ITimeReportRepository timeReportRepository;
        private readonly ITimeReportServiceConverter timeReportServiceConverter;

        public TimeReportService(ITimeReportRepository timeReportRepository, ITimeReportServiceConverter timeReportServiceConverter)
        {
            this.timeReportRepository = timeReportRepository;
            this.timeReportServiceConverter = timeReportServiceConverter;
        }

        public void CreateTimeReport(TimeReportDto timeReportDto)
        {
            var timerReportServiceModel = timeReportServiceConverter.Convert(timeReportDto);
            timeReportRepository.Create(timerReportServiceModel);
        }
    }
}