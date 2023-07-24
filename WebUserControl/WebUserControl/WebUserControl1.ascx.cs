﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebUserControl
{
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Calendar1.Visible = false;
            }
        }
                protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
                {
                    if (Calendar1.Visible == true)
                    {
                        Calendar1.Visible = false;
                    }
                    else
                    {
                        Calendar1.Visible = true;
                    }
                }
                protected void Calendar1_SelectionChanged(object sender, EventArgs e)
                {
                    TextBox1.Text = Calendar1.SelectedDate.ToShortDateString();
                }

        public string getdata
        {
            get { return TextBox1.Text; }
            set { TextBox1.Text = value; }
        }
    }
    
}