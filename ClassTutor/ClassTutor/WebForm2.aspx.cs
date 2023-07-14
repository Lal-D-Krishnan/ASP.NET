using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClassTutor
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        Class2 objC2 = new Class2();
        string english, malayalam, hindi;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(CheckBox1.Checked)
            {
                english = "true";
            }
            else
            {
                english = "false";
            }
            if (CheckBox2.Checked)
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
            int n = objC2.InsertAction("INSERT INTO Table_2 (Name,Age,Qualification,Gender,English,Malayalam,Hindi) Values ('" + TextBox1.Text + "','" + TextBox2.Text + "','"+DropDownList1.SelectedValue+"','"+RadioButtonList1.SelectedValue+"','"+english+"','"+malayalam+"','"+hindi+"')");
            if (n > 0)
            {
                Response.Write("Inserted count ");

            }
        }
    }
}