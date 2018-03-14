using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvProAssig
{
    class Staff
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public Staff(){}
        public Staff(string username, string password)
        {
            UserName = username;
            Password = password;
        }
    }
}
