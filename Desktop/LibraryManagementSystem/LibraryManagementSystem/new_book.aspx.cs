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
    public partial class new_book : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=library_management_system;Integrated Security=True;");
            con.Open();
            DataSet ds = new DataSet();
            string s = "select * from book order by bid desc";
            da = new SqlDataAdapter(s, con);
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count==0)
            {
                TextBox1.Text = "101";
            }
            else
            {
                TextBox1.Text = (Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) + 1).ToString();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s= "insert into book values("+TextBox1.Text+",'"+TextBox2.Text+"','"+TextBox3.Text+"','"+TextBox4.Text+"')";
            cmd=new SqlCommand(s,con);
            cmd.ExecuteNonQuery();
            Response.Write("<script> alert('Record Saved') </script>");
        }
    }
}