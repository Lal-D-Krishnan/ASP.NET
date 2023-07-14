using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GridView2
{
    public partial class WebForm6 : System.Web.UI.Page

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
            SqlCommand cmd = new SqlCommand("SELECT * FROM Table_7", db);
            SqlDataAdapter obj = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            obj.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            db.Close();
        }
    }
}