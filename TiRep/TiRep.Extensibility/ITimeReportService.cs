using TiRep.Extensibility.Dto;

namespace TiRep.Extensibility
{
    public interface ITimeReportService
    {
        void CreateTimeReport(TimeReportDto timeReportDto);
    }
}