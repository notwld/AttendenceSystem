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
                List<Course> courses = new DAL().ExecuteforReport<Course>("Course_GetAll()", ConnectionString.MySqlConnection());
                return courses;
            }

        

    }
}