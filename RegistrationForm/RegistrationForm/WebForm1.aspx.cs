using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace RegistrationForm
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection db = new SqlConnection();
        string English, Malayalam, Hindi;

        protected void RadioButtonList2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            db =new  SqlConnection(ConfigurationManager.ConnectionStrings["db_conn"].ConnectionString);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            db.Open();
            if (CheckBox1.Checked)
            {
                English = "true";
            }
            else
            {
                English = "false";
            }
            if (CheckBox2.Checked)
            {
                Malayalam = "true";
            }
            else
            {
                Malayalam = "false";
            }
            if (CheckBox3.Checked)
            {
                Hindi = "true";
            }
            else
            {
                Hindi = "false";
            }
            if (FileUpload1.HasFile)
            {
                FileUpload1.SaveAs(Server.MapPath("~/Newfolder1/")+FileUpload1.FileName);
            }
            SqlCommand cmd = new SqlCommand("INSERT INTO Table_7 (Name,Age,Address,Gender,Nationality,Marital_Status,English,Malayalam,Hindi,Image) VALUES ('"+TextBox1.Text+"','"+TextBox2.Text+"','"+TextBox3.Text+"','"+RadioButtonList1.SelectedValue+"','"+DropDownList1.SelectedValue+"','"+RadioButtonList2.SelectedValue+"','"+English+"','"+Malayalam+"','"+Hindi+"','"+FileUpload1.FileName+"')",db);
            int b = cmd.ExecuteNonQuery();
            if (b > 0)
            {
                Response.Write("INSERTED");
            }
            db.Close();
        }
    }
}