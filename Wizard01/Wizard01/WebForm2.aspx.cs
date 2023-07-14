using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;


namespace Wizard01
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        SqlConnection db = new SqlConnection();
        string java, javascript;

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
            CheckBox3.Checked = CheckBox1.Checked;
            CheckBox4.Checked = CheckBox2.Checked;

            if (CheckBox1.Checked)
            {
                java = "true";
            }
            else
            {
                java = "false";
            }
            if (CheckBox2.Checked)
            {
                javascript = "true";
            }
            else
            {
                javascript= "false";
            }
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
            
            SqlCommand cmd = new SqlCommand("INSERT INTO Table8 (Java,Javascript) VALUES ('"+java+"','"+javascript+"')", db);
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                Response.Write("inserted");
            }
            db.Close();
        }

    }
}