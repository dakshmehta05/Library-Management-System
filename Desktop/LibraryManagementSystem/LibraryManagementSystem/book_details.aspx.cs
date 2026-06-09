using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryManagementSystem
{
    public partial class book_details : System.Web.UI.Page
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlConnection con;
        protected void Page_Load(object sender, EventArgs e)
        {
            int b;
            b = Convert.ToInt32(Request.QueryString["a"].ToString());
            Label5.Text=b.ToString();

            con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=library_management_system;Integrated Security=True;");
            con.Open();
            DataSet ds=new DataSet();
            string s = "select * from issue where bid=" + Label5.Text + "";
            da = new SqlDataAdapter(s, con);
            da.Fill(ds);

            Label1.Text = ds.Tables[0].Rows[0][0].ToString();
            Label2.Text = ds.Tables[0].Rows[0][1].ToString();
            Label3.Text = ds.Tables[0].Rows[0][2].ToString();
            Label4.Text = ds.Tables[0].Rows[0][3].ToString();
        }
    }
}