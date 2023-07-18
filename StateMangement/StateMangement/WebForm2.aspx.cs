using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//View STATE STATE MANAGEMENT
namespace StateMangement
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ViewState["name"] = TextBox1.Text;
            Label2.Text = "the value is set";
            TextBox1.Text = "";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (ViewState["name"] !=  null)
            {
                Label2.Text = "the value is" + ViewState["name"];
                TextBox1.Text = ViewState["name"].ToString();
            }
            else
            {
                Label2.Text = "Field is empty";
            }
        }
    }
}