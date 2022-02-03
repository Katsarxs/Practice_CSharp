using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelOrganizer
{
    public static class DataOnlyExtensions
    {
        public static int GetDaysOfMonth(this DateOnly dateOnly)
            => new DateOnly(dateOnly.Year, dateOnly.Month + 1, 1).AddDays(-1).Day;
    }
}
