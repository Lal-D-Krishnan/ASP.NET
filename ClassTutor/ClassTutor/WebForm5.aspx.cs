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
    public partial class WebForm5 : System.Web.UI.Page
    {
        Class4 objC4 = new Class4();
        string english, hindi, malayalam;
        protected void Page_Load(object sender, EventArgs e) { }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(CheckBox1.Checked)
            {
                english = "true";
            }
            else
            {
                english= "false";
            }
            if(CheckBox2.Checked)
            {
                malayalam = "true";
            }
            else
            {
                malayalam = "false";
            }
            if (CheckBox3.Checked)
            {
                hindi = "true";
            }
            else
            {
                hindi = "false";
            }
            if (FileUpload1.HasFile)
            {
                FileUpload1.SaveAs(Server.MapPath("~/Newfolder2/") + FileUpload1.FileName);
            }
            int n = objC4.InsertAction("INSERT INTO Table_5 (Name,Gender,Qualification,English,Malayalam,Hindi,Image,Username) VALUES ('" + TextBox1.Text + "','" + RadioButtonList1.SelectedValue + "','" + DropDownList1.SelectedValue + "','"+english+"','"+malayalam+"','"+hindi+"','" + FileUpload1.FileName + "','" + TextBox2.Text + "')");
            objC4.InsertAction("INSERT INTO Table_8 (UserName,Password,Role) VALUES ('" + TextBox2.Text + "','" + TextBox3.Text + "','user')");

            if (n> 0)
            {
                Response.Redirect("WebForm6.aspx");
            }

        }

    }
}