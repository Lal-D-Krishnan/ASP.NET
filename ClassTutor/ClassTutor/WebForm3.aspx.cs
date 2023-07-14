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
    public partial class WebForm3 : System.Web.UI.Page
    {
        Class3 objC3 = new Class3();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                FileUpload1.SaveAs(Server.MapPath("~/Newfolder1/") + FileUpload1.FileName);
            }
            int n = objC3.InsertAction("INSERT INTO Table_3 (Name,Email,MobileNumber,Image,Username) VALUES ('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + FileUpload1.FileName + "','" + TextBox4.Text + "')");
             objC3.InsertAction("INSERT INTO Table_4 (UserName,Password,Role) VALUES ('" + TextBox4.Text + "','" + TextBox5.Text + "','user')");

            if (n > 0)
            {
                Response.Redirect("WebForm4.aspx");
            }
        }
    }
}