using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryManagementSystem
{
    public partial class s_search_book : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=library_management_system;Integrated Security=True;");
            con.Open();
            LinkButton8.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            string s = "select * from book where bid=" + TextBox1.Text + "";
            da = new SqlDataAdapter(s, con);
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count==0)
            {
                Label5.Text = "Book Not Found";
                LinkButton8.Visible = true;

            }
            else
            {
                Label1.Text = ds.Tables[0].Rows[0][0].ToString();
                Label2.Text = ds.Tables[0].Rows[0][1].ToString();
                Label3.Text = ds.Tables[0].Rows[0][2].ToString();
                Label4.Text = ds.Tables[0].Rows[0][3].ToString();
            }
        }

        protected void LinkButton8_Click(object sender, EventArgs e)
        {
            Response.Redirect("book_request.aspx");
        }
    }
}