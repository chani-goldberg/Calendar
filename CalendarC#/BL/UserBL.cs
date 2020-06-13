using DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
   public class UserBL
    {
        public static List<UserDTO> GetUsers()
        {
            return Converts.UserConvert.ConvertListUserToDTO(UserDal.GetUsers());
        }

        public static UserDTO GetUserById(int id)
        {
          return  Converts.UserConvert.ConvertUserToDTO(UserDal.GetUserById(id));
        }

        public static UserDTO AddNewUser(DTO.UserDTO user)
        {
            return Converts.UserConvert.ConvertUserToDTO(UserDal.AddNewUser(Converts.UserConvert.ConvertUserToDAL(user)));
        }

        public static int DeleteUser(int id)
        {
          return  UserDal.DeleteUser(id);
        }
    }
}
