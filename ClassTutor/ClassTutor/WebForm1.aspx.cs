using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClassTutor
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Class1 objC1 = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int n = objC1.InsertAction("INSERT INTO Table_1 (Name,Age) Values ('" + TextBox1.Text + "','" + TextBox2.Text + "')");
            if (n > 0)
            {
                Response.Write("Inserted count ");
                
            }
        }
    }
}