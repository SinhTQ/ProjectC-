using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectC
{
    public class DAO
    {
        internal static SqlConnection GetConnection()
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings["PRN292"].ToString());
        }

        internal static DataTable GetDataBySQL(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, GetConnection());
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet(); // database Cache
            ds.Clear();
            da.Fill(ds);
            return ds.Tables[0];
        }
        internal static int ExecuteSQL(string sql, params SqlParameter[] sqlParameter)
        {
            SqlCommand cmd = new SqlCommand(sql, GetConnection());
            // truyen mang tham so insert, update, delete
            cmd.Parameters.AddRange(sqlParameter);
            cmd.Connection.Open();
            int result = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return result;
        }


        internal static DataTable getAllClass()
        {
            string sql = "Select distinct ClassName from Student";
                return GetDataBySQL(sql);
        }

        internal static DataTable getAllStudentByClass(String className)
        {
            string sql = "Select * from Student where ClassName = '"+ className + "'";
            return GetDataBySQL(sql);
        }

        internal static DataTable getAllMark(string className)
        {
            return GetDataBySQL("select s.StudentID, s.StudentName, s.ClassName, d.Mark, d.Note " +
                "from Student s join Diem d " +
                "on s.StudentID = d.StudentID " +
                "where ClassName = '" + className + "'");
        }
    }
}
