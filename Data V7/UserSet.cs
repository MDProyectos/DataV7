using System.Collections.Generic;
using System.IO;

namespace Data_V7
{
    class UserSet : Isuer
    {
         private static User user;
        private static List<User> users = new List<User>();
        private static string path;
        public UserSet (string p)
        {
            path = p;
        }
        public void AddUser(User u)
        {
            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(path, true))
            {
                file.WriteLine(u.ToFile());
            }
        }

        public List<User> AllUser()
        {
            if (File.Exists(path)) 
            {  
                string[] lines = File.ReadAllLines(path);  
                foreach(string line in lines)
                {
                    string[] register = line.Split(",");
                    User u = new User(register);
                    user = u;
                    users.Add(user);
                }
            }
            return users;  
        }

        public void Delete(string id)
        {
            string[] lines = File.ReadAllLines(path); 
            using (StreamWriter writer = new StreamWriter(path))
            {
                foreach(var line in lines)
                {
                    if (line.Contains(id))
                    {
                        continue;
                    }
                    else
                    {
                        writer.WriteLine(line);
                    }
                }
            }
        }

        public void EditUser(User u, string id)
        {
            string[] lines = File.ReadAllLines(path); 
            using (StreamWriter writer = new StreamWriter(path))
            {
                foreach(var line in lines)
                {
                    if (line.Contains(id))
                    {
                        writer.WriteLine(u.ToFile());
                    }
                    else
                    {
                        writer.WriteLine(line);
                    }
                }
            }
        }

        public User GetUser(string id)
        {
            if (File.Exists(path)) 
            {  
                
                string[] lines = File.ReadAllLines(path);  
                foreach(string line in lines)
                {  
                    if (line.Contains(id))
                    {
                        string[] register = line.Split(",");
                        User u = new User(register);
                        user = u;
                        break;
                    }
                }
            }
            return user;
        }
    }
}