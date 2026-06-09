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
    public partial class new_student : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds=new DataSet();
            con=new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=library_management_system;Integrated Security=True;");
            con.Open();
            string t = "select * from stud order by roll desc";
            da=new SqlDataAdapter(t,con);
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
            string f, p;
            f = FileUpload1.FileName;
            p = Server.MapPath("~/Images/"+f);
            FileUpload1.SaveAs(p);


            string s = "insert into stud values("+TextBox1.Text+",'" + TextBox2.Text + "','" + DropDownList1.SelectedValue + "','" + DropDownList2.SelectedValue + "','" + TextBox3.Text + "','"+TextBox4.Text+"','"+TextBox5.Text+"','Images/"+f+"')";
            cmd = new SqlCommand(s, con);
            cmd.ExecuteNonQuery();
            Response.Write("<script> alert('Record Saved')  </script> ");
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            DropDownList1.SelectedIndex = 0;
            DropDownList2.SelectedIndex = 0;
        }
    }
}