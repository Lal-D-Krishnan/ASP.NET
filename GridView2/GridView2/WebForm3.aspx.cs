﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace GridView2
{
    public partial class WebForm3 : System.Web.UI.Page
    { 
        SqlConnection db = new SqlConnection();
        protected void Page_Load(object sender, EventArgs e)
        {
            db = new SqlConnection(ConfigurationManager.ConnectionStrings["db_conn"].ConnectionString);
            if (!IsPostBack)
            {
                showGrid();
            }
        }

        public void showGrid()
        {
            db.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Table1", db);

            SqlDataAdapter obj = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            obj.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            db.Close();
        }
        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "EditRow")
            {
                int rowIndex = Convert.ToInt32(e.CommandArgument);
                string id = GridView1.DataKeys[rowIndex].Value.ToString();
                string redirectUrl = "WebForm5.aspx?sid=" + id;
                System.Diagnostics.Debug.WriteLine("I'm here");

                Response.Redirect(redirectUrl);
            }
        }

       
    }
}