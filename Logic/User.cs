using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class User
    {
        public string Password { get; set; }
        public string Username { get; set; }
        public DateTime Firstlogin { get; set; }

        public static List<User> Users = new List<User>();

        public User(string username, string password, DateTime firstLogIn)
        {
            Username = username;
            Password = password;
            Firstlogin = firstLogIn;
        }
    }
}
