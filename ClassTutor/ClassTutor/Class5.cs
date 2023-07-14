using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace ClassTutor
{
    public class Class5
    {
        SqlConnection db = new SqlConnection();
        public Class5()
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
            SqlDataAdapter adapter = new SqlDataAdapter(str, db);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            db.Close();
            return dt;
        }

        public DataTable getAll(string str)
        { 
                db.Open();
                SqlCommand cmd = new SqlCommand(str, db);
                SqlDataAdapter obj = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                obj.Fill(dt);
                //GridView1.DataSource = dt;
                //GridView1.DataBind();
            db.Close();
            return dt;
        }
    }
}