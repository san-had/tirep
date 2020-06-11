using System;

namespace TiRep.Extensibility.Model
{
    public class TimeReportServiceModel
    {
        public int Id { get; set; }

        public string RecordId { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public TimeSpan Deduction { get; set; }

        public TimeSpan Balance { get; set; }

        public TimeSpan FinalBalance { get; set; }
    }
}