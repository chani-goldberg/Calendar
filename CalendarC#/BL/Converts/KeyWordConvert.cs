using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Converts
{
    public class KeyWordConvert
    {
        public static DAL.KeyWord ConvertKeyWordToDAL(DTO.KeyWordDTO kdto )
        {
            DAL.KeyWord w = new DAL.KeyWord()
            {
                KeyWordId = kdto.KeyWordId,
                KeyWord1 = kdto.KeyWord1,
                TaskTypeId = kdto.TaskTypeId
            };
            return w;
        }
        public static DTO.KeyWordDTO ConvertKeyWordToDTO(DAL.KeyWord kdal)
        {
            DTO.KeyWordDTO w = new DTO.KeyWordDTO()
            {
                KeyWordId = kdal.KeyWordId,
                KeyWord1 = kdal.KeyWord1,
                TaskTypeId = kdal.TaskTypeId
            };
            return w;
        }
    }

}
