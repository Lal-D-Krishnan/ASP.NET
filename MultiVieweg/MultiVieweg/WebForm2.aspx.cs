using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MultiVieweg
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        int n;
        protected void Page_Load(object sender, EventArgs e)
        {
            n = Convert.ToInt32(MultiView1.Views.Count.ToString());
            if (!IsPostBack)
            {
                MultiView1.ActiveViewIndex = 0;
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            if (MultiView1.ActiveViewIndex >= n)
            {
                MultiView1.ActiveViewIndex = n - 1;
            }
            if (MultiView1.ActiveViewIndex < n - 1)
            {
                MultiView1.ActiveViewIndex += 1;
            }
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            if (MultiView1.ActiveViewIndex > 0)
            {
                MultiView1.ActiveViewIndex -= 1;
            }
        }
    }
}