using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Converts
{
    public class TaskTypeConvert
    {
        public static DAL.TaskType ConvertTaskTypeToDAL(DTO.TaskTypeDTO tdto)
        {
            DAL.TaskType w = new DAL.TaskType()
            {
                TaskTypeId = tdto. TaskTypeId,
                TaskTypeName = tdto. TaskTypeName,
                Link = tdto. Link
            };
            return w;
        }
        public static DTO.TaskTypeDTO ConvertTaskTypeToDTO(DAL.TaskType tdal)
        {
            DTO.TaskTypeDTO w = new DTO.TaskTypeDTO()
            {
                TaskTypeId = tdal.TaskTypeId,
                TaskTypeName = tdal.TaskTypeName,
                Link = tdal. Link
            };
            return w;
        }

    }
}
