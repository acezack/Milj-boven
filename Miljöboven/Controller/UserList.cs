﻿using System;
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
        public int GetCount()
        {
            return userList.Count();
        }
        public string GetUserName(int index)
        {
            return userList[index].UserName;
        }
        public string Password(int index)
        {
            return userList[index].Password;
        }
        public int Type(int index)
        {
            return userList[index].Type;
        }
        public int ID(int index)
        {
            return userList[index].ID;
        }
    }
}
