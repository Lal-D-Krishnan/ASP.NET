using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ClassTutor
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        Class3 ObjC33 = new Class3();
        string role;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["uname"] = TextBox1.Text;
            DataTable dt = ObjC33.select("SELECT * FROM Table_4 WHERE UserName='"+TextBox1.Text+"' AND Password='"+TextBox2.Text+"'");
            if(dt.Rows.Count > 0 )
            {
                role = dt.Rows[0]["role"].ToString();
                if(role == "user")
                {
                    Response.Redirect("WebForm5.aspx");
                }
            }
            Label3.Text = "invalid user";
        }
    }
}