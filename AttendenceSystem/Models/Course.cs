using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AttendenceSystem.Models
{
    public class Course
    {
        public DataTable Course_GetAll()
        {
            SqlCommand sc = new SqlCommand("Select * from tbl_course", ConnectionString.MySqlConnection());
            sc.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(sc);
            sda.Fill(dt);
            return dt;
        }
    }
}