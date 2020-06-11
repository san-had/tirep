using TiRep.Domain.Database.Model;
using TiRep.Extensibility.Model;

namespace TiRep.Domain.Converters
{
    public interface ITimeReportEntityConverter :
        IEntityConverter<TimeReportServiceModel, TimeReportDbModel>,
        IEntityConverter<TimeReportDbModel, TimeReportServiceModel>
    {
    }
}