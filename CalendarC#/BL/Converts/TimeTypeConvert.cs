using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Converts
{
    public class TimeTypeConvert
    {
        public static DAL.TimeType ConvertTimeTypeToDAL(DTO.TimeTypeDTO tdto)
        {
            DAL.TimeType w = new DAL.TimeType()
            {
                TimeTypeId = tdto.TimeTypeId,
                TimeTypeName = tdto.TimeTypeName
            };
            return w;
        }
        public static DTO.TimeTypeDTO ConvertTimeTypeToDTO(DAL.TimeType tdal)
        {
            DTO.TimeTypeDTO w = new DTO.TimeTypeDTO()
            {
                TimeTypeId = tdal.TimeTypeId,
                TimeTypeName = tdal.TimeTypeName
            };
            return w;
        }

    }
}
