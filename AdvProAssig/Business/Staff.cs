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
        static List<Staff> Stafflist = new List<Staff>(); //List frequently updated by database 
        static AccessStaffRecord StaffRecord = new AccessStaffRecord(); //Access staffrecord to 
        DAO dao = new DAO(); //DAO class for making log
        //Auto-implemented properties
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
        //Constructors
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
                        dao.MakeLog($"{username} Logged in succesfully"); //Log created on succesful login
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
        public List<Staff> GetstaffList()
        {
            GetDataBaseList();
            return Stafflist;
        }
        public void AddStaff(string username, string password)
        {//Invokes dataacess layer to add object
            StaffRecord.AddStaff(username, password);
        }
        public string FindStaffMemberandDelete(string searchusername)
        {//Searches through database for administrator password to compare against username
            GetDataBaseList();
            string result;
            bool found = false;
            foreach(Staff staff in Stafflist)
            {
                if(searchusername==staff.UserName&&searchusername!="Administrator")
                {
                    found = true;
                    break;
                }
            }
            if(found)
            {
                StaffRecord.DeleteStaff(searchusername);
                result = $"{searchusername} deleted succesfully";
            }else
            {
                result = $"{searchusername} not found";
            }
            GetDataBaseList();
            return result;
        }
    }
}
