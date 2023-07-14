using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ClassTutor
{
    public class Class3
    {
        SqlConnection db = new SqlConnection();
        public Class3()
        {
            db = new SqlConnection(ConfigurationManager.ConnectionStrings["db_conn"].ConnectionString);
        }
        public int InsertAction(string str)
        {
            db.Open();
            SqlCommand cmd = new SqlCommand(str, db);
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
            db.Close();
            return dt;
        }
    }
}