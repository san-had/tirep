using System;

namespace TiRep.Service
{
    public class RecordIdParser : IRecordIdParser
    {
        public string ParseRecordId(DateTime dateTime)
        {
            string year = dateTime.Year.ToString();

            string month = ZeroPadder(dateTime.Month);

            string day = ZeroPadder(dateTime.Day);

            return year + month + day;
        }

        private string ZeroPadder(int number)
        {
            return number > 9 ? number.ToString() : "0" + number.ToString();
        }
    }
}