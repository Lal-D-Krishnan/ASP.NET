using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ClassTutor
{

    public class Class1
    {
        SqlConnection db = new SqlConnection();
        public Class1()
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