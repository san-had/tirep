using Ninject;
using TiRep.Extensibility;
using TiRep.Extensibility.Dto;

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
                EndTime = "6/4/2020 16:21:30 AM",
                Deduction = "0:20:00"
            };

            WriteStartRecord(timeReport);
        }

        private static void WriteStartRecord(TimeReportDto timeReportDto)
        {
            var kernel = new StandardKernel();
            var timereportService = kernel.Get<ITimeReportService>();
            timereportService.CreateTimeReport(timeReportDto);
        }
    }
}