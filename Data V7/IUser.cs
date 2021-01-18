using System.Collections.Generic;

namespace Data_V7
{
    interface Isuer
    {
        void AddUser(User u);
        List<User> AllUser();
        User GetUser(string id);
        void EditUser(User u, string id);
        void Delete(string id);

    }
}