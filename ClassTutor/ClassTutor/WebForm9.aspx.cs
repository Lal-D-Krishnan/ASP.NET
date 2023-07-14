using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace ClassTutor
{
    public partial class WebForm9 : System.Web.UI.Page
    {
        Class5 ObjC5 = new Class5();
        string role;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["uname"] = TextBox1.Text;
            DataTable dt = ObjC5.select("SELECT * FROM Table_8 WHERE UserName='" + TextBox1.Text + "' AND Password='" + TextBox2.Text + "'");
            if (dt.Rows.Count > 0)
            {
                role = dt.Rows[0]["role"].ToString();
                if (role == "user")
                {
                    Response.Redirect("WebForm10.aspx");
                }
            }
            Label4.Text = "invalid user";
        }
    }
}