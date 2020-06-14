using TiRep.Extensibility.Model;

namespace TiRep.Extensibility
{
    public interface ITimeReportRepository
    {
        int Create(TimeReportServiceModel timeReportModel);
    }
}