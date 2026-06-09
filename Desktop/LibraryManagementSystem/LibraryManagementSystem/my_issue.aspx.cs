using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryManagementSystem
{
    public partial class my_issue : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da1,da2;
    

        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=library_management_system;Integrated Security=True;");
            con.Open();
            DataSet ds1=new DataSet();
            string a;
            a = Session["userid"].ToString();
            Label5.Text = a.ToString();
            string s= "select * from issue where sid="+Label5.Text+"";
            da1=new SqlDataAdapter(s,con);
            da1.Fill(ds1);

            if (ds1.Tables[0].Rows.Count == 0)
            {
                Label6.Text = "No Books Borrowed";
            }

            else {
                GridView1.DataSource = ds1;
                GridView1.DataBind();
            }
        }
        
    }
}