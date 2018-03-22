using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvProAssig.DataAccess;
using System.Data;

namespace AdvProAssig
{
    public enum GraduateLevel { Undergraduate = 1, Postgraduate }
    public enum CourseLevel { Psychology=1, Business, Marketing, SoftwareDevelopment, DataAnalytics}
    class Student:ModifyStudentRecord
    {
        static public List<Student> studentlist = new List<Student>();
        static ModifyStudentRecord data = new ModifyStudentRecord();
        static private DataSet StudentDataSet;

        //Constructors
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
            return string.Format($"FirstName: {FirstName}\nSurname: {Surname}\nEmail: {Email}\nPhone: {Phone}\nAddressLine 1: {AddressLine1}\nAddressLine: {AddressLine2}\nCity: {City}\nCounty: {County}\n" +
                $"Graduate Level: {GraduateLevel}\nCourse Level: {Courselevel}\nStudent Number {StudentNumber}\n");
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
                $"'{County}'," +
                $"'{GraduateLevel}'," +
                $"'{Courselevel}'," +
                $"{StudentNumber}");
        }
        public void addtoDB()
        {
            data.AddtoDB(FirstName, Surname, Email, Phone, AddressLine1, AddressLine2, County, City, GraduateLevel, Courselevel, StudentNumber);
        }
        public static void addStudent(string firstname, string surname, string email, string phone, string addlin1, string addlin2, string county, string city, string gradlevel, string cour, int stunum)
        {
            Student newstudent = new Student(firstname, surname, email, phone, addlin1, addlin2, county, city, gradlevel, cour, stunum);
            studentlist.Add(newstudent);
            newstudent.addtoDB();
        }
        //Method takes values from Student object 
        public void ExportToXml(Student student)
        {
            //Add student object to Dataset
            DataTable DTS;
            if (StudentDataSet == null)
            {
                StudentDataSet = new DataSet("Students");
                DTS = new DataTable("Student");
                DTS.Columns.Add("FirstName");
                DTS.Columns.Add("Surname");
                DTS.Columns.Add("Email");
                DTS.Columns.Add("Phone");
                DTS.Columns.Add("AddressLine1");
                DTS.Columns.Add("AddressLine2");
                DTS.Columns.Add("County");
                DTS.Columns.Add("City");
                DTS.Columns.Add("Graduatelevel");
                DTS.Columns.Add("Course");
                DTS.Columns.Add("StudentNumber");
                StudentDataSet.Tables.Add(DTS);
            }
            DTS = StudentDataSet.Tables["Student"];
            DataRow rowstu = DTS.NewRow();
            rowstu["FirstName"] = student.FirstName;
            rowstu["Surname"] = student.Surname;
            rowstu["Email"] = student.Email;
            rowstu["Phone"] = student.Phone;
            rowstu["AddressLine1"] = student.AddressLine1;
            rowstu["AddressLine2"] = student.AddressLine2;
            rowstu["County"] = student.County;
            rowstu["City"] = student.City;
            rowstu["Graduatelevel"] = student.GraduateLevel;
            rowstu["Course"] = student.Courselevel;
            rowstu["StudentNumber"] = student.StudentNumber;
            DTS.Rows.Add(rowstu);
            DTS.AcceptChanges();

            //To export to XML
            StudentDataSet.WriteXml("Student.xml"); 
        }
        public List<Student> Exportlist(List<Student> inputlist)
        {
            PullInforfromDB();
            inputlist = studentlist;
            return inputlist;
        }
        public void PullInforfromDB()
        {
            ModifyStudentRecord sturecord = new ModifyStudentRecord();
            studentlist = sturecord.GetList();
        }
    }
    
}
