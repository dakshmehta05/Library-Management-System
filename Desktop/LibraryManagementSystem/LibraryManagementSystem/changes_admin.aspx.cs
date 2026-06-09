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
    public partial class changes_admin : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=library_management_system;Integrated Security=True;");
            con.Open();
            DataSet ds= new DataSet();
            Label1.Text = Request.QueryString["a"].ToString();
            string s= "select * from request where reqid= "+Label1.Text+"";
            da = new SqlDataAdapter(s, con);
            da.Fill(ds);
            if(ds.Tables[0].Rows.Count==0)
            {
                Label8.Text = "Invalid Request ID";
            }
            else
            {
                Label2.Text = ds.Tables[0].Rows[0][0].ToString();
                Label3.Text = ds.Tables[0].Rows[0][1].ToString();
                Label4.Text = ds.Tables[0].Rows[0][2].ToString();
                Label5.Text = ds.Tables[0].Rows[0][3].ToString();
                Label6.Text = ds.Tables[0].Rows[0][4].ToString();
                Label7.Text = ds.Tables[0].Rows[0][5].ToString();
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("available_new_book.aspx?a=" + Label2.Text + "&b=" + Label3.Text + "&c=" + Label4.Text + "&d=" + Label1.Text);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s="update request set status ='Request Rejected' where reqid="+Label1.Text+""; 
            cmd=new SqlCommand(s,con);
            cmd.ExecuteNonQuery();
            Response.Write("<script> alert('Rejected') </script>");

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string s = "update request set status ='Request Accepted' where reqid=" + Label1.Text + "";
            cmd = new SqlCommand(s, con);
            cmd.ExecuteNonQuery();
            Response.Write("<script> alert('Accepted') </script>");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string s = "update request set status ='Ordered' where reqid=" + Label1.Text + "";
            cmd = new SqlCommand(s, con);
            cmd.ExecuteNonQuery();
            Response.Write("<script> alert('Ordered') </script>");
        }
    }
}