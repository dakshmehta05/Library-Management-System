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
    public partial class available_new_book : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da,da1;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=library_management_system;Integrated Security=True;");
            con.Open();

            Label5.Text = Request.QueryString["a"].ToString();

            DataSet ds=new DataSet();
            string s = "select * from book order by bid desc";
            da = new SqlDataAdapter(s, con);
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count==0)
            {
                Label1.Text = "101";
            }
            else
            {
                Label1.Text= (Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) + 1).ToString();
               
            }
            DataSet ds1 = new DataSet();
            string t = "select * from request where reqid=" + Label1.Text;
            da1 = new SqlDataAdapter(t, con);
            da1.Fill(ds1);
            Label2.Text = ds1.Tables[0].Rows[0][0].ToString();
            Label3.Text = ds1.Tables[0].Rows[0][1].ToString();
            Label4.Text = ds1.Tables[0].Rows[0][2].ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
            string t = "insert into book values (" + Label1.Text + ", '" + Label2.Text + "', '" + Label3.Text + "', '" + Label4.Text + "')";       
            cmd=new SqlCommand(t,con);
            cmd.ExecuteNonQuery();
            string s= "update request set status ='Available with "+Label5.Text+"' where reqid= "+Label5.Text+"";
            cmd=new SqlCommand(s,con);
            cmd.ExecuteNonQuery();
            Response.Write("<script> alert('Book Added') </script> ");

        }
    }
}