using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AdvProAssig.DataAccess
{
    class ModifyStaffRecord : DAO
    {
        //Method to get all contents from Staff Database
        public List<Staff> GetStaffList()
        {
            List<Staff> updatedList = new List<Staff>();
            Staff staffmember = new Staff();
            SqlCommand GetCurrentStaffList = new SqlCommand("SELECT * FROM Staff", openConnection());
            SqlDataReader reader;
            reader = GetCurrentStaffList.ExecuteReader();
            while (reader.Read())
            {
                staffmember.UserName = reader[0].ToString();
                staffmember.Password = reader[1].ToString();
                updatedList.Add(staffmember);
            }
            closeConnection();
            return updatedList;
        }
    }
}
