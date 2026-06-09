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
    public partial class search_student : System.Web.UI.Page
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        

        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=library_management_system;Integrated Security=True;");
            con.Open();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet ds= new DataSet();
            string s= "select * from stud where roll=" +TextBox1.Text+ "";
            da=new SqlDataAdapter(s,con);
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
                Label5.Text = ds.Tables[0].Rows[0][4].ToString();
                Label6.Text = ds.Tables[0].Rows[0][5].ToString();
                TextBox1.Text = "";
                Image1.ImageUrl = ds.Tables[0].Rows[0][7].ToString();
            }
        }
    }
}