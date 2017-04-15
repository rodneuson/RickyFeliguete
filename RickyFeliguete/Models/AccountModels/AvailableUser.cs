using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RickyFeliguete.Models.AccountModels
{
    public class AvailableUser
    {
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string FullName { get; set; }

        public static List<AvailableUser> AllUsers()
        {
            List<AvailableUser> userList = new List<AvailableUser>();

            AvailableUser user1 = new AvailableUser
            {
                UserName = "Anupam Das",
                UserPassword = "lifeisbeautiful",
                FullName = "Life is Beautiful"
            };

            AvailableUser user2 = new AvailableUser
            {
                UserName = "Chinmoy Das",
                UserPassword = "GoodTime",
                FullName = "Good Time"
            };

            userList.Add(user1);
            userList.Add(user2);

            return userList;
        }
    }
}