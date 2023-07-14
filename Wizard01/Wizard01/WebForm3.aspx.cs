using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Wizard01
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        SqlConnection db = new SqlConnection();
        string english, malayalam, hindi;
        protected void Page_Load(object sender, EventArgs e)
        {
            db = new SqlConnection(ConfigurationManager.ConnectionStrings["db_conn"].ConnectionString);
            if (!IsPostBack)
            {
                showWizard();
            }
        }

        public void showWizard()
        {
            Label7.Text = TextBox1.Text; //Name
            Label8.Text = TextBox2.Text; // Age
            Label9.Text = RadioButtonList1.SelectedValue; //Gender
            Label10.Text = TextBox3.Text; //Phone_Number
            System.Diagnostics.Debug.WriteLine(TextBox3.Text);
            System.Diagnostics.Debug.WriteLine("dddddddddddddddddddddd");
            System.Diagnostics.Debug.WriteLine(TextBox2.Text);
            System.Diagnostics.Debug.WriteLine("dddddddddddddddddddddd");
            CheckBox4.Checked = CheckBox1.Checked;   //English
            CheckBox5.Checked = CheckBox2.Checked;  // Hindi
            CheckBox6.Checked = CheckBox3.Checked;  // Malayalam
            Label11.Text = DropDownList1.SelectedValue;   //Qualification



            if (CheckBox1.Checked)
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
        }

        protected void Wizard1_FinishButtonClick(object sender, WizardNavigationEventArgs e)
        {
            //showWizard();
            db.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Table8 (Name,Age,Gender,Phone_Number,English,Hindi,Malayalam,Qualification) VALUES ('" + TextBox1.Text + "','" + TextBox2.Text + "','" + RadioButtonList1.SelectedValue + "','" + TextBox3.Text + "','" + english + "','" + malayalam + "','" + hindi + "','" + DropDownList1.SelectedValue + "')", db);
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                Response.Write("inserted");
            }
            db.Close();
        }

        protected void Wizard1_NextButtonClick(object sender, WizardNavigationEventArgs e)
        { 
            if (e.NextStepIndex == 2)
            {
                showWizard();
            }
        }
    }
}


