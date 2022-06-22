using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    internal class YearAndMonth
    {
        public int Year { get; }
        public int Month { get; }

        public YearAndMonth(int year, int month)
        {
            Month = month;
            Year = year;
        }

        public static YearAndMonth GetLatestMonth(DateTime? date = null)
        {
            date ??= DateTime.Now;
            var year = date.Value.Year;
            var month = date.Value.Month;
            return month == 1
                ? new YearAndMonth(year - 1, 12)
                : new YearAndMonth(year, month - 1);
        }

        public bool Matches(DateTime date)
        {
            return date.Year == Year && date.Month == Month;
        }
    }
}
