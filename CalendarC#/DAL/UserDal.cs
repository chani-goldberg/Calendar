using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserDal
    {
        public static List<User> GetUsers()
        {
            try
            {
                using (CalendarEntities calendar = new CalendarEntities())
                {
                    return calendar.Users.ToList();
                }
            }
            catch
            {
                throw;
            }

        }

        public static User GetUserById(int id)
        {
            try
            {
                using (CalendarEntities calendar = new CalendarEntities())
                {
                    return calendar.Users.FirstOrDefault(u => u.UserId == id);
                }
            }
            catch
            {
                throw;
            }

        }

        public static User AddNewUser(User user)
        {
            try
            {
                using (CalendarEntities calendar = new CalendarEntities())
                {
                    calendar.Users.Add(user);
                    calendar.SaveChanges();
                    return user;
                }
            }
            catch
            {
                throw;
            }
        }

        public static int DeleteUser(int id)
        {
            try
            {
                using (CalendarEntities calendar = new CalendarEntities())
                {
                    var user = calendar.Users.FirstOrDefault(u => u.UserId == id);
                    if (user != null)
                    {
                        calendar.Users.Remove(user);
                        calendar.SaveChanges();
                        return user.UserId;
                    }
                    return -1;

                }
            }
            catch
            {
                throw;
            }
        }
    }
}
