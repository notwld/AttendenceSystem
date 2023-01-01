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
                    //dynamic type          Data Access Layer (DAL)
                List<Course> courses = new DAL().ExecuteforReport<Course>("Course_GetAll", ConnectionString.MySqlConnection());
                return courses;
            }

            public int Course_Save(Course course) //int type because sc.ExecuteNonQuery returns integer value which will be used in controller to identify weather query has ran or not
            {
            SqlCommand sc = new SqlCommand("Course_Save", ConnectionString.MySqlConnection());
            sc.CommandType = CommandType.StoredProcedure;
            sc.Parameters.AddWithValue("@ParamTable1", course.CourseCode);
            sc.Parameters.AddWithValue("@ParamTable2", course.CourseName);
            sc.Parameters.AddWithValue("@ParamTable3", course.CourseShortName);
            return sc.ExecuteNonQuery();
            }

            public int Course_Delete(int id)
            {
            SqlCommand sc = new SqlCommand("Course_Delete", ConnectionString.MySqlConnection());
            sc.CommandType = CommandType.StoredProcedure;
            sc.Parameters.AddWithValue("@CourseId", id);
            return sc.ExecuteNonQuery();
            }

            public int Course_Update(Course course) 
            {
            SqlCommand sc = new SqlCommand("Course_Edit", ConnectionString.MySqlConnection());
            sc.CommandType = CommandType.StoredProcedure;
            sc.Parameters.AddWithValue("@CourseId", course.CourseId);
            sc.Parameters.AddWithValue("@CourseCode", course.CourseCode);
            sc.Parameters.AddWithValue("@CourseName", course.CourseName);
            sc.Parameters.AddWithValue("@CourseShortName", course.CourseShortName);
            return sc.ExecuteNonQuery();
            }
    }
}