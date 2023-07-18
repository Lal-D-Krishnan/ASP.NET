using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateMangement
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Cookies["name"].Value = TextBox1.Text;
            Label2.Text = "The value is set";
            TextBox1.Text = "";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (Request.Cookies["name"] != null)
            {
                Response.Redirect("WebForm4.aspx");
            }
            else
            {
                Label2.Text = "Please Set Cookies";
            }
        }
    }
}