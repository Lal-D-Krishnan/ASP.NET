using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace SampleWeb
{

    public partial class WebForm4 : System.Web.UI.Page
    {
        SqlConnection db = new SqlConnection();
        string java, asp_net, python;

        protected void Page_Load(object sender, EventArgs e)
        {
            db = new SqlConnection(ConfigurationManager.ConnectionStrings["db_conn"].ConnectionString);
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            db.Open();
            if (CheckBox1.Checked == true)
            {
                asp_net = "true";
            }else
            {
                asp_net="false";
            }

            if (CheckBox2.Checked == true)
            {
                java = "true";
            }
            else
            {
                java = "false";
            }

            if (CheckBox3.Checked == true)
            {
                python = "true";
            }
            else
            {
                python = "false";
            }

            SqlCommand cmd = new SqlCommand("INSERT INTO Table1 (Name,Java,Asp_Net,Python) VALUES ('" + TextBox1.Text + "','" + java + "','" + asp_net + "','" + python + "')", db);
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                Response.Write("inserted");
            }
            db.Close();
        }
    }
}