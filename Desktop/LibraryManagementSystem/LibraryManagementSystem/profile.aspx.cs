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
    public partial class profile : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=library_management_system;Integrated Security=True;");
            con.Open();

            string a;

            a = Session["userid"].ToString ();
            Label2.Text=a.ToString(); 
            
            DataSet ds= new DataSet();
            string s="select * from stud where roll="+Label2.Text;
            da = new SqlDataAdapter(s, con);
            da.Fill(ds);

            Label3.Text = ds.Tables[0].Rows[0][1].ToString();
            Label4.Text = ds.Tables[0].Rows[0][2].ToString();
            Label5.Text = ds.Tables[0].Rows[0][3].ToString();
            Label6.Text = ds.Tables[0].Rows[0][4].ToString();
            Label1.Text = ds.Tables[0].Rows[0][5].ToString();
        }
    }
}