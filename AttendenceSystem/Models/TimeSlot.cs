using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AttendenceSystem.Models
{
    
    public class TimeSlot
    {
        public int TSId { get; set; }
        public string TSCode { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public string Status { get; set; }
        public List<TimeSlot> TimeSlot_GetAll()
        {
            //dynamic type          Data Access Layer (DAL)
            List<TimeSlot> time_slots = new DAL().ExecuteforReport<TimeSlot>("TimeSlot_GetAll", ConnectionString.MySqlConnection());
            return time_slots;
        }
        public int TimeSlot_Save(TimeSlot timeslot) //int type because sc.ExecuteNonQuery returns integer value which will be used in controller to identify weather query has ran or not
        {
            SqlCommand sc = new SqlCommand("TimeSlot_Save", ConnectionString.MySqlConnection());
            sc.CommandType = CommandType.StoredProcedure;
            sc.Parameters.AddWithValue("@ParamTable1", timeslot.TSCode);
            sc.Parameters.AddWithValue("@ParamTable2", timeslot.StartTime);
            sc.Parameters.AddWithValue("@ParamTable3", timeslot.EndTime);
            sc.Parameters.AddWithValue("@ParamTable4", timeslot.Status);
            return sc.ExecuteNonQuery();
        }
        public int TimeSlot_Delete(int id)
        {
            SqlCommand sc = new SqlCommand("TimeSlot_Delete", ConnectionString.MySqlConnection());
            sc.CommandType = CommandType.StoredProcedure;
            sc.Parameters.AddWithValue("@TimeSlotId", id);
            return sc.ExecuteNonQuery();
        }

        public int TimeSlot_Update(TimeSlot timeslot)
        {
            SqlCommand sc = new SqlCommand("TimeSlot_Edit", ConnectionString.MySqlConnection());
            sc.CommandType = CommandType.StoredProcedure;
            sc.Parameters.AddWithValue("@TimeSlotId", timeslot.TSId);
            sc.Parameters.AddWithValue("@TSCode", timeslot.TSCode);
            sc.Parameters.AddWithValue("@StartTime", timeslot.StartTime);
            sc.Parameters.AddWithValue("@EndTime", timeslot.EndTime);
            sc.Parameters.AddWithValue("@Status", timeslot.Status);
            return sc.ExecuteNonQuery();
        }
    }
}