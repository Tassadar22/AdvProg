using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvProAssig.DataAccess
{
    class ModifyStudentRecord:DAO
    {
        public void addtoDB(string firstname, string surname, string email, string phone, string addlin1, string addlin2, string county, string city, string gradlevel, string cour, int stunum)
        {
            SqlCommand addcmd = new SqlCommand("INSERT INTO Student VALUES (@StudentFirstName, @StudentSurName, @StudentEmail," +
                "@StudentPhone, @StudentAddLin1, @StudentAddLin2, @StudentCity, @StudentLevel, @StudentCourse, @StudentID)", openConnection());
            addcmd.Parameters.AddWithValue("@StudentFirstName", firstname);
            addcmd.Parameters.AddWithValue("@StudentSurName",surname);
            addcmd.Parameters.AddWithValue("@StudentEmail",email);
            addcmd.Parameters.AddWithValue("@StudentPhone",phone);
            addcmd.Parameters.AddWithValue("@StudentAllLin1",addlin1);
            addcmd.Parameters.AddWithValue("@StudentAllLin2", addlin2);
            addcmd.Parameters.AddWithValue("@StudentCity",city);
            addcmd.Parameters.AddWithValue("@StudentLevel",gradlevel);
            addcmd.Parameters.AddWithValue("@StudentCourse",cour);
            addcmd.Parameters.AddWithValue("@StudentID", stunum);
            addcmd.ExecuteNonQuery();
            closeConnection();
        }
        public void /*List<Student>*/ GetList()
        {
            /*List<Student> recentlist = new List<Student>();
            SqlCommand GetCurrentStudentList = new SqlCommand("SELECT * FROM Student", openConnection());
            SqlDataReader reader;
            reader = GetCurrentStudentList.ExecuteReader();
            while(reader.Read())
            {

            }*/
        }
        
    }
}
