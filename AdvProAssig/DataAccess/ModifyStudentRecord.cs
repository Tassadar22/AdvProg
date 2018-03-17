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
        public void AddtoDB(string firstname, string surname, string email, string phone, string addlin1, string addlin2, string county, string city, string gradlevel, string cour, int stunum)
        {
            SqlCommand addcmd = new SqlCommand("INSERT INTO Student VALUES (@StudentFirstName, @StudentSurName, @StudentEmail," +
                "@StudentPhone, @StudentAddLin1, @StudentAddLin2, @StudentCity, @StudentCounty @StudentLevel, @StudentCourse, @StudentID)", openConnection());
            addcmd.Parameters.AddWithValue("@StudentFirstName", firstname);
            addcmd.Parameters.AddWithValue("@StudentSurName",surname);
            addcmd.Parameters.AddWithValue("@StudentEmail",email);
            addcmd.Parameters.AddWithValue("@StudentPhone",phone);
            addcmd.Parameters.AddWithValue("@StudentAllLin1",addlin1);
            addcmd.Parameters.AddWithValue("@StudentAllLin2", addlin2);
            addcmd.Parameters.AddWithValue("@StudentCounty",county);
            addcmd.Parameters.AddWithValue("@StudentCity", city);
            addcmd.Parameters.AddWithValue("@StudentLevel",gradlevel);
            addcmd.Parameters.AddWithValue("@StudentCourse",cour);
            addcmd.Parameters.AddWithValue("@StudentID", stunum);
            addcmd.ExecuteNonQuery();
            closeConnection();
        }
        public List<Student> GetList()
        {
            List<Student> updatedList = new List<Student>();
            Student foundstudent = new Student();
            SqlCommand GetCurrentStudentList = new SqlCommand("SELECT * FROM Student", openConnection());
            SqlDataReader reader;
            reader = GetCurrentStudentList.ExecuteReader();
            while(reader.Read())
            {
                foundstudent.FirstName = reader[0].ToString();
                foundstudent.Surname = reader[1].ToString();
                foundstudent.Email = reader[2].ToString();
                foundstudent.Phone = reader[3].ToString();
                foundstudent.AddressLine1 = reader[4].ToString();
                foundstudent.AddressLine2 = reader[5].ToString();
                foundstudent.City = reader[6].ToString();
                foundstudent.County = reader[7].ToString();
                foundstudent.GraduateLevel = reader[8].ToString();
                foundstudent.Courselevel = reader[9].ToString();
                foundstudent.StudentNumber = int.Parse(reader[10].ToString());
                updatedList.Add(foundstudent);
            }
            closeConnection();
            return updatedList;
        }
        public string GetstringList()
        {
            string results="please be full";
            SqlCommand basicstring;
            SqlDataReader reader;
            basicstring = new SqlCommand("SELECT * FROM Student", openConnection());
            reader = basicstring.ExecuteReader();
            while(reader.Read())
            {
                results += reader[0].ToString();
                results += reader[1].ToString();
                results += reader[2].ToString();
                results += reader[3].ToString();
            }
            closeConnection();
            return results;
        }
        public Student FindRecord(int id)
        {
            Student foundstudent = new Student();
            SqlDataReader reader;
            SqlCommand IdSearch = new SqlCommand($"SELECT * FROM Student WHERE StudentID={id}", openConnection());
            reader = IdSearch.ExecuteReader();
            while(reader.Read())
            {
                foundstudent.FirstName = reader[0].ToString();
                foundstudent.Surname = reader[1].ToString();
                foundstudent.Email = reader[2].ToString();
                foundstudent.Phone = reader[3].ToString();
                foundstudent.AddressLine1 = reader[4].ToString();
                foundstudent.AddressLine2 = reader[5].ToString();
                foundstudent.City = reader[6].ToString();
                foundstudent.County = reader[7].ToString();
                foundstudent.GraduateLevel = reader[8].ToString();
                foundstudent.Courselevel = reader[9].ToString();
                foundstudent.StudentNumber = int.Parse(reader[10].ToString());
            }
            closeConnection();
            return foundstudent;
        }
        public void DeleteRecord(int id)
        {
            SqlCommand IdSearch = new SqlCommand($"DELETE * FROM Student WHERE StudentID={id}", openConnection());
            IdSearch.BeginExecuteNonQuery();
        }
    }
}
