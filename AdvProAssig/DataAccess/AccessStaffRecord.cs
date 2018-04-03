using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AdvProAssig.DataAccess
{
    class AccessStaffRecord : DAO
    {
        //Method to get all contents from Staff Database at login
        public List<Staff> GetStaffList()
        {
            List<Staff> updatedList = new List<Staff>();
            SqlCommand GetCurrentStaffList = new SqlCommand("uspGetStaffList", openConnection());
            SqlDataReader reader;
            reader = GetCurrentStaffList.ExecuteReader();
            while (reader.Read())
            {
                Staff staffmember = new Staff();
                staffmember.UserName = reader[0].ToString();
                staffmember.Password = reader[1].ToString();
                updatedList.Add(staffmember);
            }
            closeConnection();
            return updatedList;
        }
        public void AddStaff(string username, string password)
        {//Given staff query values, enter into database
            SqlCommand addstaffcmd = new SqlCommand($"INSERT INTO Staff VALUES ('{username}','{password}')", openConnection());
            addstaffcmd.ExecuteNonQuery();
            closeConnection();
        }
        public void DeleteStaff(string username)
        {//Delete record using Staff name as identifier
            SqlCommand deletestaffcmd = new SqlCommand($"DELETE FROM Staff WHERE UserName='{username}'", openConnection());
            deletestaffcmd.ExecuteNonQuery();
            closeConnection();
        }
        
        
    }
}
