using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GridView2
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        SqlConnection db = new SqlConnection();
        string gid;
        //string java, asp_net, python;
        protected void Page_Load(object sender, EventArgs e)
        {
            db = new SqlConnection(ConfigurationManager.ConnectionStrings["db_conn"].ConnectionString);
            gid = Request.Params["sid"].ToString();
            if (!IsPostBack)
            {
                showGrid();
            }
        }
        public void showGrid()
        {

            db.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Table1 WHERE id='" + gid + "'", db);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                TextBox1.Text = reader["Name"].ToString();
                if (reader["Java"].ToString() == "True")
                {
                    CheckBox1.Checked = true;
                }
                else
                {
                    CheckBox1.Checked = false;
                }
                if (reader["Asp_Net"].ToString() == "True")
                {
                    CheckBox2.Checked = true;
                }
                else
                {
                    CheckBox2.Checked = false;
                }
                if (reader["Python"].ToString() == "True")
                {
                    CheckBox3.Checked = true;
                }
                else
                {
                    CheckBox3.Checked = false;
                }
            }
            db.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            db.Open();
           
            SqlCommand cmd = new SqlCommand("UPDATE Table1 SET Name='"+TextBox1.Text+"'," +
                "Java='"+CheckBox1.Checked+"',Asp_Net='"+CheckBox2.Checked+"',Python='"+CheckBox3.Checked+"'" +
                " WHERE id='"+gid+"'", db);
            int b = cmd.ExecuteNonQuery();
            if (b > 0)
            {
                Response.Write("VALUE UPDATED");
                Response.Redirect("~/WebForm3.aspx");
            }
            db.Close();
        }
    }
}