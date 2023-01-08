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

                //sqlConnection.ConnectionString = @"Data Source=CL2-13\SQLEXPRESS; Initial Catalog=InstituteAttendenceSystem;User=sa;Password=UIT12345";
               sqlConnection.ConnectionString = @"Data Source=DESKTOP-58G7CRO; Initial Catalog=InstituteAttendenceSystem;Integrated Security = True";
                sqlConnection.Open();
            }

            return sqlConnection;
        }
    }
}