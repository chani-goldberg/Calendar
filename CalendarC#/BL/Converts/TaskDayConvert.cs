using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Converts
{
     public class TaskDayConvert
    {
        public static DAL.TaskDay ConvertTaskDayToDAL(DTO.TaskDayDTO tdto)
        {
            DAL.TaskDay w = new DAL.TaskDay()
            {
                TaskId= tdto.TaskId,
                DayInWeek= tdto.TaskId
            };
            return w;
        }
        public static DTO.TaskDayDTO ConvertTaskDayToDTO(DAL.TaskDay tdal)
        {
            DTO.TaskDayDTO w = new DTO.TaskDayDTO()
            {
                TaskId = tdal.TaskId,
                DayInWeek = tdal.TaskId
            };
            return w;
        }
    }
}
