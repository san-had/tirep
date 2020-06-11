using Ninject.Modules;
using TiRep.Extensibility;
using TiRep.Service;

namespace TiRep.Con
{
    public class ConsoleNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ITimeReportService>().To<TimeReportService>();
        }
    }
}