using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Security;


namespace ClassTutor
{ 
    public partial class WebForm6 : System.Web.UI.Page
{
    Class4 ObjC4 = new Class4();
    string role;
    
        protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["uname"] = TextBox1.Text;
        DataTable dt = ObjC4.select("SELECT * FROM Table_8 WHERE UserName='" + TextBox1.Text + "' AND Password='" + TextBox2.Text + "'");
        if (dt.Rows.Count > 0)
        {
            role = dt.Rows[0]["role"].ToString();
            if (role == "user")
            {
                Response.Redirect("WebForm7.aspx");
            }
        }
        Label4.Text = "invalid user";
    }
}
}