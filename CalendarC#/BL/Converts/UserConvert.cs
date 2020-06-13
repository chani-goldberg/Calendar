using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Converts
{
    public class UserConvert
    {
        //לעשות המרה בהכל גם לליסט וכן לטפל בשגיאות אם זה ריק וכו
        public static DAL.User ConvertUserToDAL(DTO.UserDTO udto)
        {
            if (udto == null)
                return null;
            DAL.User w = new DAL.User()
            {
                UserId = udto.UserId,
                UserFirstName = udto.UserFirstName,
                UserLastName = udto.UserLastName,
                UserEmail = udto.UserEmail,
                UserPassword = udto.UserPassword,
                UserGooglePassword = udto.UserGooglePassword
            };
            return w;
        }
        public static DTO.UserDTO ConvertUserToDTO(DAL.User udal)
        {
            if (udal == null)
                return null;
            DTO.UserDTO w = new DTO.UserDTO()
            {
                UserId = udal.UserId,
                UserFirstName = udal.UserFirstName,
                UserLastName = udal.UserLastName,
                UserEmail = udal.UserEmail,
                UserPassword = udal.UserPassword,
                UserGooglePassword = udal.UserGooglePassword
            };
            return w;
        }

        public static List<DTO.UserDTO> ConvertListUserToDTO(List<DAL.User> lusers)
        {
            List<DTO.UserDTO> l = new List<DTO.UserDTO>();
            lusers.ForEach(u=>l.Add(ConvertUserToDTO(u)));
            return l;
        }
    }
}
