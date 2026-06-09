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
    public partial class book_request : System.Web.UI.Page
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;

        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=library_management_system;Integrated Security=True;");
            con.Open();

            DataSet ds = new DataSet();
            string a;
            a = Session["userid"].ToString();
            Label1.Text = a.ToString();
            string k = "select * from request order by reqid desc";
            da=new SqlDataAdapter(k,con);
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count ==0)
            {
                Label2.Text = "01";
            }
            else
            {
                Label2.Text = (Convert.ToInt32(ds.Tables[0].Rows[0][6].ToString()) + 1).ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //DateTime dt = DateTime.Now;
            //string date=dt.ToString("yyyy-MM-dd");
            string s = "insert into request values ('" + TextBox1.Text + "', '" + TextBox2.Text + "', '" + TextBox3.Text + "',"+Label1.Text+",'"+DateTime.Now.ToShortDateString()+"','Pending...',"+Label2.Text+" )";
            cmd=new SqlCommand(s,con);
            cmd.BeginExecuteNonQuery();
            Response.Write("<script>  alert('Requested')   </script>");
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";

        }
    }
}