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
    public partial class login : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da1,da2;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=library_management_system;Integrated Security=True;");
            con.Open();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet ds1=new DataSet();
            string s= "select * from login where userid='"+TextBox1.Text+"' and upass='"+TextBox2.Text+"'";
            da1 = new SqlDataAdapter(s, con);
            da1.Fill(ds1);

            if (ds1.Tables[0].Rows.Count == 0)
            {
                DataSet ds2 = new DataSet();
                string k = "select * from stud where roll=" + TextBox1.Text + " and spass='" + TextBox2.Text + "'";
                da2 = new SqlDataAdapter(k, con);
                da2.Fill(ds2);

                if (ds2.Tables[0].Rows.Count == 0)
                {
                    Label1.Text = "Invalid ID or Password";
                    TextBox1.Text = "";
                    TextBox2.Text = "";
                }

                else
                {
                    Session["userid"] = TextBox1.Text;
                    Response.Redirect("profile.aspx");
                }
            }
            else
            {
                Response.Redirect("home.aspx");
            }

            
        }
    }
}