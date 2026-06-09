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
    public partial class message : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;

        public object LinkButton2 { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=library_management_system;Integrated Security=True;");
            con.Open();
            DataSet ds = new DataSet();
            string s = "select * from message";
            da = new SqlDataAdapter(s, con);
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
        public void Delete_message(object sender, CommandEventArgs e)
        {
            string mid;
            mid = e.CommandName;
            string t;
            t="delete from message where mid = "+mid+"";
            cmd=new SqlCommand(t,con);
            cmd.ExecuteNonQuery();
            Response.Redirect("message.aspx");
            
        }

        public void hide(object sender, CommandEventArgs e)
        {
            
        }

        protected void LinkButton2_Command(object sender, CommandEventArgs e)
        {
            string msgid;
            msgid = e.CommandName;
            string t;
            LinkButton lk = (LinkButton)sender;

            if (lk.Text == "Hide")
            {
                t = "UPDATE message SET status = 'Show' WHERE mid=" + msgid +"";
                cmd = new SqlCommand(t, con);
                cmd.ExecuteNonQuery();
                lk.Text = "Show";
            }
            else
            {

                t = "UPDATE message SET status = 'Hide' WHERE mid=" + msgid + "";
                cmd = new SqlCommand(t, con);
                cmd.ExecuteNonQuery();
                lk.Text = "Hide";
            }
            DataSet ds = new DataSet();
            string s = "select * from message";
            da = new SqlDataAdapter(s, con);
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
    }
}