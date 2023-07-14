using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace FormView01
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection db = new SqlConnection();
        protected void Page_Load(object sender, EventArgs e)
        {
            db = new SqlConnection(ConfigurationManager.ConnectionStrings["db_conn"].ConnectionString);
            if(!IsPostBack)
            {
                showFormView();
            }
        }

        public void showFormView()
        {
            db.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Table1",db);
            SqlDataAdapter ddk = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            ddk.Fill(ds);
            FormView1.DataSource = ds;
            FormView1.DataBind();
            db.Close();
        }
    }
}