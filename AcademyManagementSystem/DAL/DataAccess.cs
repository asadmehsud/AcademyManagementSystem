using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyManagementSystem.DAL
{
    internal class DataAccess
    {
        public static int SpexecuteQuery(String SpName, SqlParameter[] prm)
        {
            SqlConnection con = new SqlConnection("server=DESKTOP-B3SMOPA\\SQLEXPRESS01;database=DbAcademyManagementSystem;integrated security=true");
            SqlCommand cmd = new SqlCommand(SpName, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddRange(prm);
            con.Open();
            int check = cmd.ExecuteNonQuery();
            con.Close();
            return check;
        }
        public static DataTable SpGetData(String SpName, SqlParameter prm)
        {
            SqlConnection con = new SqlConnection("server=DESKTOP-B3SMOPA\\SQLEXPRESS01;database=DbAcademyManagementSystem;integrated security=true");
            SqlCommand cmd = new SqlCommand(SpName, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(prm);
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            return dt;
        }
        public static DataTable SpGetData(string SpName, SqlParameter[] prm)
        {
            SqlConnection con = new SqlConnection("server=DESKTOP-B3SMOPA\\SQLEXPRESS01;database=DbAcademyManagementSystem;integrated security=true");
            SqlCommand cmd = new SqlCommand(SpName, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddRange(prm);
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            return dt;
        }
        public static DataTable SpGetData(string query)
        {
            SqlConnection con = new SqlConnection("server=DESKTOP-B3SMOPA\\SQLEXPRESS01;database=DbAcademyManagementSystem;integrated security=true");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            return dt;
        }
 
    }
}
