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
    public partial class show_requests : System.Web.UI.Page
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=library_management_system;Integrated Security=True;");
            con.Open();

            DataSet ds = new DataSet();
            string s = "select * from request";
            da = new SqlDataAdapter(s, con);
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        public void reject(object sender, CommandEventArgs e)
        {
            string rid;
            rid = e.CommandName;
            string s = "UPDATE request SET status = 'Reject' WHERE reqid = " + rid;
            cmd=new SqlCommand(s,con);  
            cmd.ExecuteNonQuery();
        }

        public void accept(object sender, CommandEventArgs e)
        {
            string rid;
            rid = e.CommandName;
            string s = "UPDATE request SET status = 'Accepted' WHERE reqid = " + rid;
            cmd = new SqlCommand(s, con);
            cmd.ExecuteNonQuery();
        }

        public void order(object sender, CommandEventArgs e)
        {
            string rid;
            rid = e.CommandName;
            string s = "UPDATE request SET status = 'Ordered' WHERE reqid = " + rid;
            cmd = new SqlCommand(s, con);
            cmd.ExecuteNonQuery();
        }

        public void available(object sender, CommandEventArgs e)
        {
            string rid;
            rid = e.CommandName;
            string s = "UPDATE request SET status = 'Available' WHERE reqid = " + rid;
            cmd = new SqlCommand(s, con);
            cmd.ExecuteNonQuery();
            Response.Redirect("available_new_book.aspx?a=" + rid);
        }


    }
}

//changes_admin  and  avaialable_new_book  are not in the linkbutton even they are child pages of master page 1 becoz they are dependent on showrequest button