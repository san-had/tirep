using TiRep.Extensibility.Dto;
using TiRep.Extensibility.Model;

namespace TiRep.Service
{
    public interface ITimeReportServiceConverter :
        IServiceConverter<TimeReportDto, TimeReportServiceModel>,
        IServiceConverter<TimeReportServiceModel, TimeReportDto>
    {
    }
}