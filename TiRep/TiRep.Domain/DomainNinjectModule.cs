using Ninject.Modules;
using TiRep.Domain.Converters;
using TiRep.Domain.Repositories;
using TiRep.Extensibility;

namespace TiRep.Domain
{
    public class DomainNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ITimeReportRepository>().To<TimeReportRepository>();
            Bind<ITimeReportEntityConverter>().To<TimeReportEntityConverter>();
        }
    }
}