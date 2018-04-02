using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;

namespace AdvProAssig.DataAccess
{
    class DAO
    {
        private SqlConnection conn;
        string connectionstring = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=StudentDataBase;Integrated Security=True;";
        public DAO()
        {
            conn = new SqlConnection(connectionstring);
        }
        public SqlConnection openConnection()
        {
            if (conn.State == System.Data.ConnectionState.Closed || conn.State == System.Data.ConnectionState.Closed)
                conn.Open();
            return conn;
        }
        public void closeConnection()
        {
            if (conn.State == System.Data.ConnectionState.Open)
                conn.Close();
        }
        public void MakeLog(string historyfile)
        {
            string AddLog = $"\nMessage {DateTime.UtcNow}\t",filename="databasehistory.log";
            //Sanity checking, create log if it doesn't exist
            if (!File.Exists(filename))
            {
                File.Create(filename);
            }
            AddLog += string.Format($"{historyfile}");
            File.AppendAllText(filename, AddLog);
        }
    }
}
