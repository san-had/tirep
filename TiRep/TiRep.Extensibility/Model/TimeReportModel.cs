using System;

namespace TiRep.Extensibility.Model
{
    public class TimeReportModel
    {
        public TimeReportModel(
            DateTime startTime,
            string recordId,
            DateTime endTime,
            TimeSpan deduction)
        {
            RecordId = recordId;
            StartTime = startTime;
            EndTime = endTime;
            Deduction = deduction;
        }

        public int Id { get; set; }

        public string RecordId { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public TimeSpan Deduction { get; set; }

        public TimeSpan Balance { get; set; }

        public TimeSpan FinalBalance { get; set; }
    }
}