using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using IS_Attendance_Machine_Project;

namespace IS_Attendance_Machine_Project
{
    public class DAT
    {
        public static string ConnString = @"Data Source=JOP-PC\SQLEXPRESS;Initial Catalog=ISAttandaceManagementSystem;Integrated Security=SSPI";
        SqlConnection conn;

        public DAT()
        {
            conn = new SqlConnection(ConnString);
        }
        public void ExecuteCommand(string commString)
        {
            conn.Open();
            SqlCommand commExecuteCommand = new SqlCommand(commString, conn);
            commExecuteCommand.ExecuteNonQuery();
            commExecuteCommand.Dispose();
            conn.Close();
        }
        public SqlDataReader getData(string drString)
        {
            SqlConnection conn = new SqlConnection(ConnString);
            conn.Open();
            SqlCommand commAccessData = new SqlCommand(drString, conn);
            SqlDataReader drAccessData = commAccessData.ExecuteReader();
            return drAccessData;
            conn.Close();
        }
    }
}