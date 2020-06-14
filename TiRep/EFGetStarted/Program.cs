using System;
using System.Linq;

namespace EFGetStarted
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Writing TimeReport....");

            using (var db = new TimeReportContext())
            {
                // Create
                Console.WriteLine("Inserting a new timeReport");
                db.Add(new TimeReport { TimeReportText = "20200614" });
                db.SaveChanges();

                // Create
                Console.WriteLine("Inserting a new timeReport");
                db.Add(new TimeReport { TimeReportText = "20200615" });
                db.SaveChanges();

                // Create
                Console.WriteLine("Inserting a new timeReport");
                db.Add(new TimeReport { TimeReportText = "20200616" });
                db.SaveChanges();

                // Read
                Console.WriteLine("Querying for a timeReport");
                var timeReport = db.TimeReports
                    .OrderBy(tr => tr.Id)
                    .First();

                // Update
                Console.WriteLine("Updating the timeReport and adding a post");
                timeReport.TimeReportText = "https://devblogs.microsoft.com/dotnet";
                db.SaveChanges();

                // Delete
                Console.WriteLine("Delete the timeReport");
                db.Remove(timeReport);
                db.SaveChanges();
            }
        }
    }
}