using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace SampleWeb
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        SqlConnection db = new SqlConnection();

        protected void Page_Load(object sender, EventArgs e)
        {
            db = new SqlConnection(ConfigurationManager.ConnectionStrings["db_conn"].ConnectionString);

           }

    protected void Button1_Click(object sender, EventArgs e)
        {
            db.Open();
            if (FileUpload1.HasFile)
            {
                FileUpload1.SaveAs(Server.MapPath("~/NewFolder1/")+FileUpload1.FileName);
            }
            SqlCommand cmd = new SqlCommand("INSERT INTO Table4 (Name,Image) VALUES ('" + TextBox1.Text + "','" + FileUpload1.FileName + "')", db);
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                Response.Write("inserted");
            }

            db.Close();
        }
    }
}