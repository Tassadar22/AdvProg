﻿using System;
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
            //CONSIDER DELETING
            SqlCommand addcmd = new SqlCommand($"INSERT INTO Student VALUES ('{firstname}', '{surname}', '{email}'," +
                $"'{phone}', '{addlin1}', '{addlin2}', '{city}', '{county}', '{gradlevel}', '{cour}', {stunum})", openConnection());

            addcmd.ExecuteNonQuery();
            closeConnection();
        }
        public List<Student> GetList()
        {
            List<Student> updatedList = new List<Student>();
            SqlCommand GetCurrentStudentList = new SqlCommand("uspGetStudentList", openConnection());
            SqlDataReader reader;
            reader = GetCurrentStudentList.ExecuteReader();
            while(reader.Read())
            { 
                Student foundstudent = new Student();
                foundstudent.FirstName = reader[0].ToString();
                foundstudent.Surname = reader[1].ToString();
                foundstudent.Email = reader[2].ToString();
                foundstudent.Phone = reader[3].ToString();
                foundstudent.AddressLine1 = reader[4].ToString();
                foundstudent.AddressLine2 = reader[5].ToString();
                foundstudent.City = reader[6].ToString();
                foundstudent.County = reader[7].ToString();
                foundstudent.GraduateLevel = reader[8].ToString();
                foundstudent.Course = reader[9].ToString();
                foundstudent.StudentNumber = int.Parse(reader[10].ToString());
                updatedList.Add(foundstudent);
            }
            closeConnection();
            return updatedList;
        }
        //CONSIDER REMOVING
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
                foundstudent.Course = reader[9].ToString();
                foundstudent.StudentNumber = int.Parse(reader[10].ToString());
            }
            closeConnection();
            return foundstudent;
        }
        public void DeleteRecord(int id)
        {
            SqlCommand IDdelete = new SqlCommand($"DELETE FROM Student WHERE StudentID={id}", openConnection());
            IDdelete.ExecuteNonQuery();
            closeConnection();
        }
    }
}
