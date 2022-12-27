using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AttendenceSystem
{
    public class ConnectionString
    {
        public static SqlConnection sqlConnection;

        public static SqlConnection MySqlConnection()
        {
            if (sqlConnection == null)
            {
                sqlConnection = new SqlConnection();

                sqlConnection.ConnectionString = @"Data Source=CL2-04\SQLEXPRESS; Initial Catalog=InstituteAttendenceSystem;User=sa;Password=UIT12345";
                sqlConnection.Open();
            }

            return sqlConnection;
        }
    }
}