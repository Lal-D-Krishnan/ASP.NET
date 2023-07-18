using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GridView2
{
    public partial class WebForm9 : System.Web.UI.Page
    {

        SqlConnection db = new SqlConnection();
        string gid;
        protected void Page_Load(object sender, EventArgs e)
        {
            db = new SqlConnection(ConfigurationManager.ConnectionStrings["db_conn"].ConnectionString);
            gid = Request.Params["sid"].ToString();
            if (!IsPostBack)
            {
                populateField();
            }
        }

        public void populateField()
        {
            db.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Table4 WHERE id='" + gid + "'", db);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                TextBox1.Text = reader["Name"].ToString();
                System.Diagnostics.Debug.WriteLine(reader["Image"].ToString());
                Image1.ImageUrl = "~/NewFolder1/"+ reader["Image"].ToString();
            }
            db.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                FileUpload1.SaveAs(Server.MapPath("~/NewFolder1/") + FileUpload1.FileName);
            db.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Table4 SET Name='" + TextBox1.Text + "', Image='" + FileUpload1.FileName + "' WHERE id='" + gid + "'", db);
                int b = cmd.ExecuteNonQuery();
                if (b > 0)
                {
                    Response.Write("VALUE UPDATED");
                    Response.Redirect("~/WebForm2.aspx");
                }
            db.Close();
            }
            else
            {
                db.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Table4 SET Name='" + TextBox1.Text + "' WHERE id='" + gid + "'", db);
                int b = cmd.ExecuteNonQuery();
                if (b > 0)
                {
                    Response.Write("VALUE UPDATED");
                    Response.Redirect("~/WebForm2.aspx");
                }
                db.Close();
            }
        }
    }
}