using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Converts
{
    public class MyTaskConvert
    {
        public static DAL.MyTask ConvertMyTaskToDAL(DTO.MyTaskDTO mdto)
        {
            DAL.MyTask w = new DAL.MyTask()
            {
                TaskId = mdto.TaskId,
                UserId = mdto.UserId,
                TaskTitle = mdto.TaskTitle,
                TaskContent = mdto.TaskContent,
                StartDate = mdto. StartDate,
                EndDate = mdto. EndDate,
                AdvanceAlertTime = mdto.AdvanceAlertTime,
                TaskTypeId = mdto.TaskTypeId
            };
            return w;
        }
        public static DTO.MyTaskDTO ConvertMyTaskToDTO(DAL.MyTask mdal)
        {
            DTO.MyTaskDTO w = new DTO.MyTaskDTO()
            {
                TaskId = mdal.TaskId,
                UserId = mdal.UserId,
                TaskTitle = mdal.TaskTitle,
                TaskContent = mdal.TaskContent,
                StartDate = mdal.StartDate,
                EndDate = mdal.EndDate,
                AdvanceAlertTime = mdal.AdvanceAlertTime,
                TaskTypeId = mdal.TaskTypeId
            };
            return w;
        }

    }
}
