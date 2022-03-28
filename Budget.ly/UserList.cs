using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget.ly
{
    public class UserList
    {

        List<User> userList;

        UserList()
        {

            this.userList = new List<User>() {};

        }

        void AddUser(User user)
        {

            this.userList.Add(user);

        }

        void RemoveUser(User user)
        {

            foreach (User listedUser in this.userList)
            {

                if (listedUser == user)
                {

                    this.userList.Remove(listedUser);

                }

            }

        }

    }
}
