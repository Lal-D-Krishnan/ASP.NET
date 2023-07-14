using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Security.Cryptography.X509Certificates;

namespace ListView1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection db = new SqlConnection();

        protected void Page_Load(object sender, EventArgs e)
        {
            db = new SqlConnection(ConfigurationManager.ConnectionStrings["lalkrishnanConnectionString"].ConnectionString);
            if (!IsPostBack)
            {
                showList();
            }
        }

        public void showList()
        {
            db.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Table_7",db);
            ListView1.DataSourceID = null;
            SqlDataAdapter adapter =  new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            ListView1.DataSource = dt;
            ListView1.DataBind();
            db.Close();
        }
    }
}