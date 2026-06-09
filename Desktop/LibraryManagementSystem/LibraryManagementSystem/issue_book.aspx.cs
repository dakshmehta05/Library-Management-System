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
    public partial class issue_book : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da1,da2,da3;

        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=library_management_system;Integrated Security=True;");
            con.Open();
            Label2.Text = DateTime.Now.ToShortDateString();
            Label3.Text = DateTime.Now.AddDays(15).ToShortDateString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet ds1 = new DataSet();
            DataSet ds2 = new DataSet();
            DataSet ds3 = new DataSet();
            string check1="select * from stud where roll="+TextBox2.Text+"";
            da1 = new SqlDataAdapter(check1, con);
            da1.Fill(ds1);

            if (ds1.Tables[0].Rows.Count==0)
            {
                Label1.Text = "Invalid Student ID";
            }            
            else 
            {
                string check2 = "select * from book where bid=" + TextBox1.Text + "";
                da2 = new SqlDataAdapter(check2, con);
                da2.Fill(ds2);

                if (ds2.Tables[0].Rows.Count == 0)
                    Label1.Text = "Invalid Book ID";
                else
                {
                    string check3 = "select * from issue where bid=" + TextBox1.Text + "";
                    da3 = new SqlDataAdapter(check3, con);
                    da3.Fill(ds3);
                    if (ds3.Tables[0].Rows.Count != 0)
                        Label1.Text = "Book Already Issued";
                    else
                    {
                        string s = "insert into issue values(" + TextBox1.Text + "," + TextBox2.Text + ",'" + Label2.Text + "','" + Label3.Text  + "')";
                        cmd = new SqlCommand(s, con);
                        cmd.ExecuteNonQuery();
                        Response.Write("<script>  alert('Record Saved')  </script>");
                        TextBox1.Text = "";
                        TextBox2.Text = "";
                       // TextBox3.Text = "";
                        //TextBox4.Text = "";
                    }
                }
            }
            
        }
    }
}