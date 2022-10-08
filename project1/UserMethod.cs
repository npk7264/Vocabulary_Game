using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace project1
{
    public class UserMethod
    {
        public static bool WriteFile(string nickname, int score, string topic, string path)
        {
            StreamWriter sw = new StreamWriter(path, true, Encoding.UTF8);
            string line = nickname + ";" + score;
            sw.WriteLine(line);
            sw.Close();
            return true;
        }

        public static bool WriteFileUsers(List<User> users, string path)
        {
            StreamWriter sw = new StreamWriter(path, true, Encoding.UTF8);
            foreach (User u in users)
            {
                string line = u.Name + ";" + u.Score;
                sw.WriteLine(line);
            }
            sw.Close();
            return true;
        }

        public static List<User> ReadFile(string path)
        {
            List<User> list = new List<User>();
            StreamReader sr = new StreamReader(path, Encoding.UTF8);
            string line = sr.ReadLine();
            while (line != null)
            {
                string[] arr = line.Split(';');
                if (arr.Length == 2)
                {
                    User user = new User();
                    user.Name = arr[0];
                    user.Score = int.Parse(arr[1]);
                    list.Add(user);
                }
                line = sr.ReadLine();
            }
            return list;
        }
    }
}


