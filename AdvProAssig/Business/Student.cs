using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvProAssig.DataAccess;

namespace AdvProAssig
{
    public enum GraduateLevel { Undergraduate = 1, Postgraduate }
    public enum CourseLevel { Psychology=1, Business, Marketing, SoftwareDevelopment, DataAnalytics}
    class Student
    {
        static List<Student> studentlist = new List<Student>();
        static ModifyStudentRecord data = new ModifyStudentRecord();

        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string GraduateLevel { get; set; }
        public string Courselevel { get; set; }
        public int StudentNumber { get; set; }

        public Student() { }
        public Student(string firstname, string surname, string email, string phone, string addlin1, string addlin2, string county, string city, string gradlevel, string cour, int stunum)
        {
            FirstName = firstname;
            Surname = surname;
            Email = email;
            Phone = phone;
            AddressLine1 = addlin1;
            AddressLine2 = addlin2;
            City = city;
            County = county;
            GraduateLevel = gradlevel;
            Courselevel = cour;
            StudentNumber = stunum;
        }
        public override string ToString()
        {
            return string.Format($"FirstName: {FirstName} Surname: {Surname} Email: {Email} Phone: {Phone} AddressLine 1: {AddressLine1} AddressLine: {AddressLine2} City: {City} County: {County}" +
                $"Graduate Level: {GraduateLevel} Course Level: {Courselevel} Student Number {StudentNumber}");
        }
        public string ToDatabaseString()
        {
            return string.Format($"INSERT INTO Student VALUES(" +
                $"'{FirstName}'," +
                $"'{Surname}'," +
                $"'{Email}'," +
                $"'{Phone}'," +
                $"'{AddressLine1}'," +
                $"'{AddressLine2}'," +
                $"'{City}'," +
                $"'{GraduateLevel}'," +
                $"'{Courselevel}'," +
                $"{StudentNumber}");
        }
        public void addtoDB()
        {
            data.addtoDB(FirstName, Surname, Email, Phone, AddressLine1, AddressLine2, County, City, GraduateLevel, Courselevel, StudentNumber);
        }
        public static void addStudent(string firstname, string surname, string email, string phone, string addlin1, string addlin2, string county, string city, string gradlevel, string cour, int stunum)
        {
            Student newstudent = new Student(firstname, surname, email, phone, addlin1, addlin2, county, city, gradlevel, cour, stunum);
            studentlist.Add(newstudent);
            newstudent.addtoDB();
        }
    }
    
}
