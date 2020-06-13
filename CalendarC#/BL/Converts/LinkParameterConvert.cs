using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Converts
{
    public class LinkParameterConvert
    {
        public static DAL.LinkParameter ConvertLinkParameterToDAL(DTO.LinkParameterDTO cdto)
        {
            DAL.LinkParameter w = new DAL.LinkParameter()
            {
                ParameterId = cdto.ParameterId,
                ParameterName = cdto.ParameterName,
                KeyWordId = cdto.KeyWordId,
                PositionWord = cdto.PositionWord
            };
            return w;
        }
        public static DTO.LinkParameterDTO ConvertLinkParameterToDTO(DAL.LinkParameter cdal)
        {
            DTO.LinkParameterDTO w = new DTO.LinkParameterDTO()
            {
                ParameterId = cdal.ParameterId,
                ParameterName = cdal.ParameterName,
                KeyWordId = cdal.KeyWordId,
                PositionWord = cdal.PositionWord
            };
            return w;
        }

    }
}
