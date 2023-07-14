using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ClassTutor
{
    public partial class WebForm10 : System.Web.UI.Page
    {
        Class5 objC5 = new Class5();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                showGrid();
            }
        }

        public void showGrid()
        {
            DataTable d = objC5.getAll("SELECT * FROM Table_5");
            GridView1.DataSource = d;
            GridView1.DataBind();
            
        }
    }
}