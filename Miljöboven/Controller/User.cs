using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miljöboven.Controller
{
    public class User
    {
        public String UserName { get; set; }
        public String Password { get; set; }
        public Int32 Type { get; set; }
        public Int32 ID { get; set; }

        public User(string userName, string password, int type, int id)
        {
            this.UserName = userName;
            this.Password = password;
            this.Type = type;
            this.ID = id;
        }
    }
}
