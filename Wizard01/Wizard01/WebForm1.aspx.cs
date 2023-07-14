using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Wizard01
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection db = new SqlConnection();
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
            Label4.Text = TextBox1.Text;
            Label5.Text = TextBox2.Text;
            Label6.Text = DropDownList1.SelectedValue;
        }

        protected void Wizard1_NextButtonClick(object sender, WizardNavigationEventArgs e)
        {
            if (e.NextStepIndex == 1)
            {
                showWizard();
            }
        }

        protected void Wizard1_FinishButtonClick(object sender, WizardNavigationEventArgs e)
        {
            db.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Table8 (Name,Age,Place) VALUES ('" + TextBox1.Text + "','" + TextBox2.Text + "','" + DropDownList1.SelectedValue + "')", db);
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                Response.Write("inserted");
            }
            db.Close();
            
        }
    }
}