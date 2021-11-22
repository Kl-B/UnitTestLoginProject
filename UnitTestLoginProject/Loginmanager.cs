using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UnitTestLoginProject
{
    public class Loginmanager
    {
        public bool RegisterNewUser(string username, string password, DateTime today)
        {
            var Newuser = new User(username, password, DateTime.Today);
            
            if (password.Length < 16 && password.Length > 8 && username.Length < 16)
            {
                Regex regex = new Regex("^(?=.*?[a-öA-Ö])(?=.*?[0-9])(?=.*?[(!”#¤%&/()=?_*’)]).{8,}$");
                bool validPassword = regex.IsMatch(password);

                Regex regex2 = new Regex("^[a-zA-Z0-9-_]+$");
                bool validUsername = regex2.IsMatch(username);

                if (validPassword && validUsername)
                {
                    if (Newuser.Username == username)
                    {
                        User.Users.Add(Newuser);

                        foreach (var u in User.Users) 
                        {
                            if (u.Password == password && u.Username == username)
                            {
                                return true;
                            }
                        }
                               
                    }
                }

            }

            return false;

        }
    }
}
