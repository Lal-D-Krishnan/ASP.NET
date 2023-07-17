using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateMangement
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HiddenField1.Value = TextBox1.Text;
            Label2.Text = "the value is set";
            TextBox1.Text = "";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if(HiddenField1.Value != "")
            {
                HiddenField1.Visible = true;
                Label2.Text = "the value is"+ HiddenField1.Value;
                TextBox1.Text = HiddenField1.Value;
            }
            else
            {
                Label2.Text = "Field is empty";
            }
        }
    }
}