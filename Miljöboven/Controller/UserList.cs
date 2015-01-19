using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miljöboven.Controller
{
    public class UserList
    {
        List<User> userList = new List<User>();

        public void Add(User user)
        {
            userList.Add(user);
        }
    }
}
