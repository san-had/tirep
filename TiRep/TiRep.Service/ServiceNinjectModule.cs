using Ninject.Modules;
using TiRep.Extensibility;

namespace TiRep.Service
{
    public class ServiceNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IRecordIdParser>().To<RecordIdParser>();
            Bind<IDateTimeProvider>().To<DateTimeProvider>();
            Bind<ITimeReportServiceConverter>().To<TimeReportServiceConverter>();
            Bind<ITimeReportService>().To<TimeReportService>();
        }
    }
}