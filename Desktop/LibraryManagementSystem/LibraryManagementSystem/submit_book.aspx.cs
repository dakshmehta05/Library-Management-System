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
    public partial class submit_book : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=library_management_system;Integrated Security=True;");
            con.Open();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            string s = "select * from issue where bid="+TextBox1.Text+"";
            da = new SqlDataAdapter(s, con);
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count==0)
            {
                Response.Write("<script>  alert('Record not Found')  </script>");
                TextBox1.Text = "";
            }
            else
            {
                Label1.Text = ds.Tables[0].Rows[0][0].ToString();
                Label2.Text = ds.Tables[0].Rows[0][1].ToString();
                Label3.Text = ds.Tables[0].Rows[0][2].ToString();
                Label4.Text = ds.Tables[0].Rows[0][3].ToString();
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string s="delete from issue where bid="+Label1.Text+"";
            cmd=new SqlCommand(s,con);
            cmd.ExecuteNonQuery();
            Response.Write("<script>  alert('Record Deleted')  </script>");
            Label1.Text = "";
            Label2.Text = "";
            Label3.Text = "";
            Label4.Text = "";
            TextBox1.Text = "";
        }

        protected void LinkButton10_Click(object sender, EventArgs e)
        {
            int a;
            Response.Redirect("check_book.aspx?a="+Label1.Text);
        }

        protected void LinkButton11_Click(object sender, EventArgs e)
        {
            int a;
            Response.Redirect("check_student.aspx?a=" + Label2.Text);
        }
    }
}