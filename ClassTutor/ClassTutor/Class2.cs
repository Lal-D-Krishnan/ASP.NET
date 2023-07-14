using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ClassTutor
{
    public class Class2
    {
        SqlConnection db = new SqlConnection();
        public Class2()
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
    }
}