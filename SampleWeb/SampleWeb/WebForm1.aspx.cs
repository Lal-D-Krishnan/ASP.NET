using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace SampleWeb
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection db = new SqlConnection();
        protected void Page_Load(object sender, EventArgs e)
        {
            db = new SqlConnection(ConfigurationManager.ConnectionStrings["db_conn"].ConnectionString);

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            db.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO sampletable (Name,Age) VALUES ('" + TextBox1.Text + "','" + TextBox2.Text + "')", db);
            int a=cmd.ExecuteNonQuery();
            if(a>0)
            {
                Response.Write("inserted");
            }

            db.Close();
        }
    }
}