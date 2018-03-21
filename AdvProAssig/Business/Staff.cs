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
        static ModifyStaffRecord StaffRecord = new ModifyStaffRecord();
        
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
            //Method to extract data from database and get student 
            Stafflist = StaffRecord.GetStaffList();
        }
        public bool UserNameChecker(string username)
        {
            bool searchresult = false;
            foreach(Staff user in Stafflist)
            {
                if(username.ToLower()==user.UserName.ToLower())
                {
                    searchresult = true;
                }
            }
            return searchresult;
        }
        
    }
}
