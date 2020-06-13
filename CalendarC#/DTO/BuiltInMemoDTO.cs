using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BuiltInMemoDTO
    {
        public int MemoId { get; set; }
        public string MemoName { get; set; }
        public int HebrewTimeId { get; set; }
        public Nullable<int> DayInWeek { get; set; }
        public string HebrewDayStart { get; set; }
        public string HebrewMonthStart { get; set; }
        public string HebrewDayEnd { get; set; }
        public string HebrewMonthEnd { get; set; }
    }
}
