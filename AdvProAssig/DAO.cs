using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AdvProAssig
{
    class DAO
    {
        SqlConnection conn;
        string connectionstring = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=StudentDataBase;Integrated Security=True;";
        public DAO()
        {
            conn = new SqlConnection(connectionstring);
        }
        //Consider changing to void method
        public bool AddServerData()
        {
            SqlCommand createStudentTable = new SqlCommand("CREATE TABLE Student(" +
                    "StudentFirstName VARCHAR(10)," +
                    "StudentSurName VARCHAR(20)," +
                    "StudentEmail VARCHAR(50)," +
                    "StudentPhone VARCHAR(20)," +
                    "StudentAddLin1 VARCHAR(20)," +
                    "StudentAddLin2 VARCHAR(20)," +
                    "StudentCity VARCHAR(20)," +
                    "StudentLevel VARCHAR(25)," +
                    "StudentCourse VARCHAR(20)," +
                    "StudentID INT)", conn);
            SqlCommand addStudent1 = new SqlCommand("INSERT INTO Student VALUES(" +
                "'John','Smith','John@DBS.com','4159879','45 Merrion Square'," +
                "'Dublin 2','Dublin','UnderGraduate','Psychology',45645688)", conn);
            SqlCommand addStudent2 = new SqlCommand("INSERT INTO Student Values(" +
                 "'Mary', 'Smith', 'Mary@DBS.com', '0872146455'," +
                 "'20 the Green', 'Rathmines', 'Dublin 10', 'PostGraduate', 'Marketing', 45678912)", conn);
            SqlCommand addStudent3 = new SqlCommand("INSERT INTO Student Values(" +
                  "'Max', 'Power', 'Max@DBS.com', '0894561245'," +
                 "'54 Briarwood', 'StoneyBatter', 'Dublin 7', 'UnderGraduate', 'Business', 78451254)", conn);
            try
            {
                using (conn)
                {
                    conn.Open();
                    createStudentTable.ExecuteNonQuery();
                    addStudent1.ExecuteNonQuery();
                    addStudent2.ExecuteNonQuery();
                    addStudent3.ExecuteNonQuery();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool AddStudent(Student student)
        {
            SqlCommand addstudent = new SqlCommand(student.ToDatabaseString(),conn);
            try
            {
                using (conn)
                {
                    conn.Open();
                    addstudent.ExecuteNonQuery();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        //FINISH
        public void Findstudent(int id)
        {

            //return Student
        }
        public List<Student> GetList()
        {
            List<Student> list = new List<Student>();
            SqlCommand Getstudentlist = new SqlCommand("SELECT * FROM Student", conn);
            SqlDataReader reader;
            try
            {
                conn.Open();
                reader = Getstudentlist.ExecuteReader();
                while(reader.Read())
                {
                    Student student = new Student();
                    student.FirstName = reader[0].ToString();
                }
            }catch(Exception ex)
            {

            }
            return list;

        }
        
    }
}
