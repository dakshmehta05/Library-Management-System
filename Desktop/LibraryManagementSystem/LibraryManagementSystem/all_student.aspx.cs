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
    public partial class all_students : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=library_management_system;Integrated Security=True;");
            con.Open();
            DataSet ds = new DataSet();
            string s = "select roll,sname,branch,semester,phone,email from stud";
            da = new SqlDataAdapter(s, con);
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {

        }
        public void delete_record(object sender, CommandEventArgs e)
        {
            string rno;
            rno = e.CommandName;
            //Response.Write("<Script>alert('Testing')</script>");
            string s;
            SqlCommand cmd;
            s = "Delete from stud where roll="+rno;
            cmd = new SqlCommand(s, con);
            cmd.ExecuteNonQuery();
            Response.Redirect("all_student.aspx");
        }
    }
}