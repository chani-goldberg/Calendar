using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Converts
{
    public class MyMemoConvert
    {
        public static DAL.MyMemo ConvertMyMemoToDAL(DTO.MyMemoDTO mdto)
        {
            DAL.MyMemo w = new DAL.MyMemo()
            {
                MyMemoId = mdto.MyMemoId,
                MemoId = mdto.MemoId,
                UserId = mdto.UserId,
                AdvanceAlertTime = mdto.AdvanceAlertTime,
                AlertName = mdto.AlertName
            };
            return w;
        }
        public static DTO.MyMemoDTO ConvertMyMemoToDTO(DAL.MyMemo mdal)
        {
            DTO.MyMemoDTO w = new DTO.MyMemoDTO()
            {
                MyMemoId = mdal.MyMemoId,
                MemoId = mdal.MemoId,
                UserId = mdal.UserId,
                AdvanceAlertTime = mdal.AdvanceAlertTime,
                AlertName = mdal.AlertName
            };
            return w;
        }
    }
}

