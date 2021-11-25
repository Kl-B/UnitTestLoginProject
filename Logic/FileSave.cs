using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Logic
{
    public class FileSave : ISave
    {
        private string _path;

        public FileSave(string path)
        {
            _path = path;
        }

        public List<User> Load()
        {
            var users = new List<User>();

            if (File.Exists(_path))
            {
                using var sr = new StreamReader(_path);

                var line = sr.ReadLine();
                while (line != null)
                {
                    var stringData = line.Split(",");

                    var user = new User();
                    user.Firstlogin = DateTime.Parse(stringData[0]);
                    user.Username = stringData[1];
                    user.Password = stringData[2];

                    users.Add(user);

                    line = sr.ReadLine();
                }
            }

            return users;
        }

        public void Save(List<User> users)
        {
            using var sr = new StreamWriter(_path);

            foreach (var user in users)
            {
                string newUser = user.Firstlogin + "," + user.Password + "," + user.Username;

                sr.WriteLine(newUser);
            }
        }
    }
}
