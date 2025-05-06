using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Library
{
    internal class DatabaseHelper
    {
        private static readonly DatabaseHelper _instance = new();
        private readonly string connectionString;

        private DatabaseHelper()
        {
            connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        }

        public static DatabaseHelper Instance => _instance;

        public DataTable ExecuteQuery(string query, SqlParameter[]? sp = null)
        {
            DataTable dt = new();

            try
            {
                using SqlConnection conn = new(connectionString);
                conn.Open();

                using SqlCommand cmd = new(query, conn);
              
                if (sp != null)
                {
                    cmd.Parameters.AddRange(sp);
                }

                using SqlDataAdapter da = new(cmd);

                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error executing query: " +  ex.Message);
            }

            return dt;
        }

        public int ExecuteNonQuery(string query, SqlParameter[]? sp = null)
        {
            int rowsAffected = 0;

            try
            {
                using SqlConnection conn = new(connectionString);
                conn.Open();

                using SqlCommand cmd = new(query, conn);

                if (sp != null)
                {
                    cmd.Parameters.AddRange(sp);
                }

                rowsAffected = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error executing non-query: " + ex.Message);
            }

            return rowsAffected;
        }
    }
}
