using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace boarding__management_system
{
    internal class Function
    {
        private SqlConnection Con;
        private string ConStr;

        public Function()
        {
            ConStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\bimya\OneDrive\Documents\myDB.mdf;Integrated Security=True;Connect Timeout=30";
            Con = new SqlConnection(ConStr);
        }

        public DataTable GetData(string query, string paramName1, object paramValue1, string paramName2 = null, object paramValue2 = null)
        {
            DataTable dt = new DataTable();
            using (SqlCommand cmd = new SqlCommand(query, Con))
            {
                cmd.Parameters.AddWithValue(paramName1, paramValue1);
                if (paramName2 != null && paramValue2 != null)
                {
                    cmd.Parameters.AddWithValue(paramName2, paramValue2);
                }
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    sda.Fill(dt);
                }
            }
            return dt;
        }

        public int SetData(string query, string paramName1, object paramValue1, string paramName2, object paramValue2)
        {
            int rowsAffected = 0;
            using (SqlCommand cmd = new SqlCommand(query, Con))
            {
                cmd.Parameters.AddWithValue(paramName1, paramValue1);
                cmd.Parameters.AddWithValue(paramName2, paramValue2);
                if (Con.State == ConnectionState.Closed)
                {
                    Con.Open();
                }
                rowsAffected = cmd.ExecuteNonQuery();
            }
            return rowsAffected;
        }
    }
}



