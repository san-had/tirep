using Ninject;
using TiRep.Domain;
using TiRep.Extensibility;
using TiRep.Extensibility.Dto;
using TiRep.Service;

namespace TiRep.Con
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Console.WriteLine(DateTime.Now);

            var timeReport = new TimeReportDto
            {
                StartTime = "6/4/2020 8:15:30 AM",
                EndTime = "6/4/2020 4:21:30 PM",
                Deduction = "0:20:00"
            };

            WriteStartRecord(timeReport);
        }

        private static void WriteStartRecord(TimeReportDto timeReportDto)
        {
            var kernel = new StandardKernel();
            kernel.Load<ServiceNinjectModule>();
            kernel.Load<DomainNinjectModule>();
            var timereportService = kernel.Get<ITimeReportService>();

            timereportService.CreateTimeReport(timeReportDto);
        }
    }
}