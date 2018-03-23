using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvProAssig.DataAccess;

namespace AdvProAssig
{
    class Staff
    {
        static List<Staff> Stafflist = new List<Staff>();
        static AccessStaffRecord StaffRecord = new AccessStaffRecord();
        
        public string UserName { get; set; }
        public string Password { get; set; }
        public Staff(){}
        public Staff(string username, string password)
        {
            UserName = username;
            Password = password;
        }
        public void GetDataBaseList()
        {
            //Method to extract data from database and get stafflist 
            Stafflist = StaffRecord.GetStaffList();
        }
        public char UserNamePasswordChecker(string username, string password)
        {
            //Update Main staff list with updated staff list
            GetDataBaseList();
            //Default code if username or password are never found
            char result = 'c';
            foreach(Staff user in Stafflist)
            {
                if(username.ToLower()==user.UserName.ToLower())
                {
                    if (password == user.Password)
                    {
                        //Character to represent proper username & password entered
                        result = 'a';
                        break;
                    }
                    else
                    {
                        //Character returned when username exists but incorrect password entered
                        result = 'b';
                        break;
                    }
                }
            }
            return result;
        }
        
    }
}
