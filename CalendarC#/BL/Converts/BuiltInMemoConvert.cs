using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Converts
{
   public class BuiltInMemoConvert
    {
        public static DAL.BuiltInMemo ConvertBuiltInMemoToDAL(DTO.BuiltInMemoDTO cdto)
        {
            DAL.BuiltInMemo w = new DAL.BuiltInMemo()
            {
                MemoId = cdto.MemoId,
                MemoName = cdto.MemoName,
                HebrewTimeId = cdto.HebrewTimeId,
                DayInWeek = cdto.DayInWeek,
                HebrewDayStart = cdto.HebrewDayStart,
                HebrewMonthStart = cdto.HebrewMonthStart,
                HebrewDayEnd = cdto.HebrewDayEnd,
                HebrewMonthEnd = cdto.HebrewMonthEnd
            };
            return w;
        }
        public static DTO.BuiltInMemoDTO ConvertToDTO(DAL.BuiltInMemo cdal)
        {
            DTO.BuiltInMemoDTO w = new DTO.BuiltInMemoDTO()
            {
                MemoId = cdal.MemoId,
                MemoName = cdal.MemoName,
                HebrewTimeId = cdal.HebrewTimeId,
                DayInWeek = cdal.DayInWeek,
                HebrewDayStart = cdal.HebrewDayStart,
                HebrewMonthStart = cdal.HebrewMonthStart,
                HebrewDayEnd = cdal.HebrewDayEnd,
                HebrewMonthEnd = cdal.HebrewMonthEnd
            };
            return w;
        }
    }
}

