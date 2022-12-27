using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Web;

namespace AttendenceSystem
{
    public class DAL
    {
        public List<T> ExecuteforReport<T>(string StoredProcedure, SqlConnection sqlConnection)
        {
            SqlCommand sc = new SqlCommand(StoredProcedure, sqlConnection);
            sc.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sda = new SqlDataAdapter(sc);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            List<T> data = new List<T>();
            data = ConvertDataTable<T>(dt);
            return data;
        }

        public DataTable ExecuteforDT(string StoredProcedure, string[] parameters, SqlConnection sqlConnection)
        {
            SqlCommand sc = new SqlCommand(StoredProcedure, sqlConnection);
            sc.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < parameters.Length; i++)
            {
                sc.Parameters.AddWithValue("@ParamTable" + (i + 1), parameters[i]);
            }
            SqlDataAdapter sda = new SqlDataAdapter(sc);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        private static List<T> ConvertDataTable<T>(DataTable dt)
        {
            List<T> data = new List<T>();
            foreach (DataRow row in dt.Rows)
            {
                T item = GetItem<T>(row);
                data.Add(item);
            }
            return data;
        }

        private static T GetItem<T>(DataRow dr)
        {
            Type temp = typeof(T);
            T obj = Activator.CreateInstance<T>();

            foreach (DataColumn column in dr.Table.Columns)
            {
                foreach (PropertyInfo pro in temp.GetProperties())
                {
                    if (pro.Name == column.ColumnName)
                        pro.SetValue(obj, dr[column.ColumnName], null);
                    else
                        continue;
                }
            }
            return obj;
        }
    }
}