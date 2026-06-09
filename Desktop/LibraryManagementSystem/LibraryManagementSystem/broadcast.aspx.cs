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
    public partial class broadcast : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=library_management_system;Integrated Security=True;");
            con.Open();
            DataSet ds=new DataSet();
            string t = "select * from message order by mid desc";
            da = new SqlDataAdapter(t, con);
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count==0)
            {
                Label1.Text = "01";
            }
            else
            {
                Label1.Text = (Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) + 1).ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s = "insert into message values (" + Label1.Text + ", '" + TextBox2.Text + "','"+TextBox1.Text+"', '" + DateTime.Now.ToShortDateString() + "', 'Sent')";
            cmd=new SqlCommand(s,con);
            cmd.ExecuteNonQuery();
            Response.Write("<script> alert('Message sent') </script> ");
            TextBox1.Text = "";
            
        }
    }
}