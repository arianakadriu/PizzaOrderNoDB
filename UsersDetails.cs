using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrder
{
    class UsersDetails
    {
        public static List<User> users = new List<User>();
        public static List<OrderInfo> orderInfos = new List<OrderInfo>();

        public static void LoadUsers()
        {
            User user1 = new User();
            user1.Username = "ariana.kadriu";
            user1.Password = "1234";
            user1.Firstname = "Ariana";
            user1.Lastname = "Kadriu";
            user1.Email = "ariana.kadriu@umib.net";
            user1.StatusId = 1;
            users.Add(user1);

            User user2 = new User();
            user2.Username = "fatlind.rexhepi";
            user2.Password = "1234";
            user2.Firstname = "Fatlind";
            user2.Lastname = "Rexhepi";
            user2.Email = "fatlind.rexhepi@umib.net";
            user2.StatusId = 1;
            users.Add(user2);
        }
    }
}
