using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvProAssig
{
    /*public enum GraduateLevel { Undergraduate = 1, Postgraduate }
    public enum CourseLevel { Psychology=1, Business, Marketing, SoftwareDevelopment, DataAnalytics}*/
    class Student
    {
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

    }
    
}
