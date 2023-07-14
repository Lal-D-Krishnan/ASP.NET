using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ClassTutor
{
    public class Class4
    {
        SqlConnection db = new SqlConnection();
        public Class4()
        {
            db = new SqlConnection(ConfigurationManager.ConnectionStrings["db_conn"].ConnectionString);
        }

        public int InsertAction(string str)
        {
            db.Open();
            SqlCommand cmd = new SqlCommand(str,db);
            int a = cmd.ExecuteNonQuery();
            db.Close();
            return a;
        }

        public DataTable select(string str)
        {
            db.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(str,db);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }
}