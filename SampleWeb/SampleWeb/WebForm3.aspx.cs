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
    public partial class WebForm3 : System.Web.UI.Page
    {
        SqlConnection db = new SqlConnection();

        protected void Page_Load(object sender, EventArgs e)
        {
            db = new SqlConnection(ConfigurationManager.ConnectionStrings["db_conn"].ConnectionString);
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            db.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO personDetails (Name,Age,Educational_Qualification,Gender) VALUES ('" + TextBox1.Text + "','" + TextBox2.Text + "','"+ DropDownList1.SelectedValue+ "','"+RadioButtonList1.SelectedValue+"')", db);
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                Response.Write("inserted");
            }
            db.Close();
        }
    }
}