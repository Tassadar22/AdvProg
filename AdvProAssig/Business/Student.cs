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
        public string Course { get; set; }
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
            Course = cour;
            StudentNumber = stunum;
        }
        //Function to insure that valid inputs are entered
        public static string StudentAddingValidator(string firstnamein, string surnamein, string emailin, string phonein, string addlin1in, string addlin2in, string countyin, string cityin, string gradlevelin, string courin, string stunumin)
        {
            //Outcome message to be passed to program
            string outcome="";
            //Boolean toggle to indicate whether the passed values meet validation requirements
            bool makeobject = true,checkdatabase=true;
            int studentnumber;
            //Check Length of integer
            if(stunumin.Length!=8)
            {
                outcome += "Student Number can only be eight digits long\n";
                makeobject = false;
                checkdatabase = false;
            }//Check if integer value is 
            if (!int.TryParse(stunumin, out studentnumber))
            {
                outcome += "Student Number must only contain an integer\n";
                makeobject = false;
                checkdatabase = false;//boolean flag which performs prevalidation check to see if database should be checked
            }
            if (checkdatabase)
            {
                if(CheckDBforStudentID(studentnumber))
                {
                    makeobject = false;
                    outcome += "Similar ID already exists in database\n";
                }
            }
            //Check if proper county name is entered
            if (!CheckCountyList(countyin))
            {
                outcome += "Improper county named entered\n";
                makeobject = false;
            }
            if(gradlevelin== "None selected")
            {
                outcome += "You must select the Graduate status of the student\n";
                makeobject = false;
            }
            if(!CourseChecker(courin))
            {
                outcome += "You must select a course value\n";
                makeobject = false;
            }
            if(!EmptyChecker(firstnamein,surnamein,emailin,phonein,addlin1in,addlin2in,cityin))
            {
                outcome += "No Field can be left empty\n";
            }
            if(makeobject)
            {//Object meets validation 
                outcome = "Data Succesfully Added";
                Student.addStudent(firstnamein, surnamein, emailin, phonein, addlin1in, addlin2in, countyin, cityin, gradlevelin, courin, studentnumber);
            }
            return outcome;
        }
        public override string ToString()
        {
            return string.Format($"FirstName: {FirstName}\nSurname: {Surname}\nEmail: {Email}\nPhone: {Phone}\nAddressLine 1: {AddressLine1}\nAddressLine: {AddressLine2}\nCity: {City}\nCounty: {County}\n" +
                $"Graduate Level: {GraduateLevel}\nCourse Level: {Course}\nStudent Number {StudentNumber}\n");
        }
        /*public string ToDatabaseString()
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
                $"'{Course}'," +
                $"{StudentNumber}");
        }*/
        public void addtoDB()
        {
            data.AddtoDB(FirstName, Surname, Email, Phone, AddressLine1, AddressLine2, County, City, GraduateLevel, Course, StudentNumber);
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
            rowstu["Course"] = student.Course;
            rowstu["StudentNumber"] = student.StudentNumber;
            DTS.Rows.Add(rowstu);
            DTS.AcceptChanges();

            //To export to XML
            StudentDataSet.WriteXml("Student.xml"); 
        }
        public List<Student> Exportlist(List<Student> inputlist)
        {
            PullInfofromDB();
            inputlist = studentlist;
            return inputlist;
        }
        public static void PullInfofromDB()
        {
            ModifyStudentRecord sturecord = new ModifyStudentRecord();
            studentlist = sturecord.GetList();
        }
        static bool CheckCountyList(string countynameinput)
        {
            bool result = false;
            List<string> Countylist = new List<string>();
            Countylist.Add("Antrim");
            Countylist.Add("Armagh");
            Countylist.Add("Carlow");
            Countylist.Add("Cavan");
            Countylist.Add("Clare");
            Countylist.Add("Cork");
            Countylist.Add("Derry");
            Countylist.Add("Donegal");
            Countylist.Add("Down");
            Countylist.Add("Dublin");
            Countylist.Add("Fermanagh");
            Countylist.Add("Galway");
            Countylist.Add("Kerry");
            Countylist.Add("Kildare");
            Countylist.Add("Kilkenny");
            Countylist.Add("Laois");
            Countylist.Add("Leitrim");
            Countylist.Add("Limerick");
            Countylist.Add("Longford");
            Countylist.Add("Louth");
            Countylist.Add("Mayo");
            Countylist.Add("Meath");
            Countylist.Add("Monaghan");
            Countylist.Add("Offaly");
            Countylist.Add("Roscommon");
            Countylist.Add("Sligo");
            Countylist.Add("Tipperary");
            Countylist.Add("Tyrone");
            Countylist.Add("Waterford");
            Countylist.Add("Westmeath");
            Countylist.Add("Wexford");
            Countylist.Add("Wicklow");
            foreach(string county in Countylist)
            {
                if(countynameinput==county)
                {
                    result = true;
                }
            }
            return result;
        }
        static bool CourseChecker(string coursenamechecking)
        {
            bool result = false;
            string[] Courselist = { "Psychology", "Business", "Marketing", "Software Development", "DataAnalytics" };
            foreach(string coursename in Courselist)
            {
                if(coursenamechecking==coursename)
                {
                    result = true;
                    
                }
            }
            return result;
        }
        static bool EmptyChecker(string firstname, string surname, string email, string phone, string addlin1, string addlin2, string city)
        {
            if(string.IsNullOrEmpty(firstname)|| string.IsNullOrEmpty(surname)|| string.IsNullOrEmpty(phone)|| string.IsNullOrEmpty(addlin1)|| string.IsNullOrEmpty(addlin2) || string.IsNullOrEmpty(city))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool CheckDBforStudentID(int id)
        {
            //Function to check local list to see if similar ID already exists
            bool idfound = false;
            PullInfofromDB();
            foreach (Student studentname in studentlist)
            {
                if (studentname.StudentNumber == id)
                {
                    idfound = true;
                      break;
                }
            }
            return idfound;
        }
        public static Student StudentFinder(int id)
        {
            return studentlist.Find(x => x.StudentNumber == id);
        }
    }
    
}
