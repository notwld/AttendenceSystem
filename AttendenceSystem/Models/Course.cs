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

            public int CourseId { get; set; }
            public string CourseCode { get; set; }
            public string CourseName { get; set; }
            public string CourseShortName { get; set; }

            public List<Course> Course_GetAll()
            {
                List<Course> courses = new DAL().ExecuteforReport<Course>("Course_GetAll", ConnectionString.MySqlConnection());
                return courses;
            }

            public int Course_Save(Course course)
        {
            SqlCommand sc = new SqlCommand("Course_Save", ConnectionString.MySqlConnection());
            sc.CommandType = CommandType.StoredProcedure;
            sc.Parameters.AddWithValue("@ParamTable1", course.CourseCode);
            sc.Parameters.AddWithValue("@ParamTable2", course.CourseName);
            sc.Parameters.AddWithValue("@ParamTable3", course.CourseShortName);
            return sc.ExecuteNonQuery();
        }
        

    }
}